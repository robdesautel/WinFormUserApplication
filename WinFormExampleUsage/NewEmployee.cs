using AdventureWorksEntity.Model;
using Repository.PersonRepository;
using WinFormExampleUsage.CustomLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinFormExampleUsage.Outgoing.Person;
using UserValidation.PasswordInteraction;

namespace WinFormExampleUsage
{
    public partial class NewEmployee : Form
    {
        private List<Outgoing.Person.Person> people;
        private int businessEntityPersonID;
        private int businessEntityContactID;
        private int addressID;
        private Login Login;
        public NewEmployee(Login login)
        {
            InitializeComponent();
            this.Login = login;
            loadPhoneNumberTypes();
            loadPersonTypes();
            loadStateProvince();
            loadPersonTitle();
            loadPersonSuffix();
            loadContactTypes();
            loadContactAddressTypes();
            personBusinnessEntityID();
        }
        private void loadPersonTitle()
        {
            this.personTitle.DataSource = ComboBoxDataSource.personTitles();
            this.personTitle.DisplayMember = "titleName";

        }

        private void loadPersonSuffix()
        {
            this.personSuffix.DataSource = ComboBoxDataSource.personSuffixes();
            this.personSuffix.DisplayMember = "personSuffix";
        }

        private void loadPersonTypes()
        {
            this.personContactInformation.DataSource = ComboBoxDataSource.personTypes();
            this.personContactInformation.DisplayMember = "personTypeName";
            this.personContactInformation.ValueMember = "personTypeCode";
        }

        private void loadStateProvince()
        {
            using (var context = new Entities())
            {
                //CountryRegion is an ambigious name.
                var stateProvice = new Repository.PersonRepository.StateProvince(context);
                var StateProvinces = stateProvice.stateProvinces().ToList();
                this.personStateProvince.DataSource = StateProvinces;
            }
            this.personStateProvince.DisplayMember = "Name";
            this.personStateProvince.ValueMember = "StateProvinceID";
        }

        private void loadPhoneNumberTypes()
        {

            using (var context = new Entities())
            {
                var PhoneNumberTypes = new PhoneNumberTypes(context);
                var phoneNumberTypes = PhoneNumberTypes.phoneNumberTypes().ToList();
                this.cellPhoneTypes.DataSource = phoneNumberTypes;
            }
            this.cellPhoneTypes.DisplayMember = "Name";
            this.cellPhoneTypes.ValueMember = "PhoneNumberTypeID";
        }

        private void loadContactTypes()
        {
            using(var context = new Entities())
            {
                // contact type is an ambiguous name
                var ContactTypes = new Repository.PersonRepository.ContactType(context);
                var contactTypes = ContactTypes.contactTypes().ToList();
                this.personContactTypes.DataSource = contactTypes;
            }
            this.personContactTypes.DisplayMember = "Name";
            this.personContactTypes.ValueMember = "ContactTypeID";
        }

        private void loadContactAddressTypes()
        {
            using(var context = new Entities())
            {
                var AddressTypes = new Repository.PersonRepository.AddressType(context);
                var addressTypes = AddressTypes.addressTypes().ToList();
                this.personAddressType.DataSource = addressTypes;
            }
            this.personAddressType.DisplayMember = "Name";
            this.personAddressType.ValueMember = "AddressTypeID";
        }

        private void personAddContact_Click(object sender, EventArgs e)
        {
            addNewPerson();
            
        }

        private void saveContactButton_Click(object sender, EventArgs e)
        {
            var context = new Entities();
            Outgoing.Person.SavePerson savePerson = new Outgoing.Person.SavePerson(context);
            savePerson.AddPerson(people);
            savePerson.InsertPerson();
        }


        private void addNewPerson()
        {
            people = new List<Outgoing.Person.Person>();
            CreateUserPassword(out string hashSalt, out string newpassword);
            int emailPromotion = 0;
            if (this.personRecieveEmails.Checked)
            {
                emailPromotion = 1;
            }

            people.Add(new Outgoing.Person.Person()
            { 
                BusinessEntityID = this.businessEntityPersonID,
                PersonType = this.personContactInformation.SelectedValue.ToString(),
                NameStyle = false,
                Title = this.personTitle.Text,
                FirstName = this.personFirstName.Text,
                MiddleName = "",
                LastName = this.personLastName.Text,
                Suffix = this.personSuffix.Text,
                EmailPromotion = emailPromotion,
                Demographics = null,
                AdditionalContactInformation = null,
                address = new Outgoing.Person.Address
                {
                    Address1 = this.personAddress1.Text,
                    Address2 = this.personAddress1.Text,
                    StateProvinceID = (int)this.personStateProvince.SelectedValue,
                    City = this.personCity.Text,
                    PostalCode = this.personZipCode.Text
                },
                businessEntity = new Outgoing.Person.BusinessEntity
                {
                    BusinessEntityID = this.businessEntityPersonID
                },
                businessEntityAddress = new Outgoing.Person.BusinessEntityAddress
                {
                    AddressID = this.addressID++,
                    BusinessEntityID = this.businessEntityPersonID,
                    AddressTypeID = (int)this.personAddressType.SelectedValue

                },
                businessEntityContact = new Outgoing.Person.BusinessEntityContact
                {
                    BusinessEntityID = this.businessEntityContactID,
                    ContactTypeID = (int)this.personContactTypes.SelectedValue,
                    PersonID = this.businessEntityPersonID

                },
                emailAddress = new Outgoing.Person.EmailAddress
                {
                    emailAddress = this.personEmailAddress.Text,
                    BusinessEntityID = this.businessEntityPersonID

                },
                phoneNumber = new PhoneNumber
                {
                    BusinessEntityID = this.businessEntityPersonID,
                    PersonPhoneNumber = this.personPhoneNumber.Text,
                    PhoneNumberType = (int)this.cellPhoneTypes.SelectedValue
                },
                userPassword = new UserPassword
                {
                    BusinessEntityID = this.businessEntityPersonID,
                    PasswordSaltyHas = newpassword,
                    Salt = hashSalt
                }
            });
        }

        private void CreateUserPassword(out string hashSalt, out string newPassword)
        {
            var createNewUserLogin = new UserLogin();
            var hashPass = createNewUserLogin.newPassword(this.personPassword.Text);
            hashSalt = createNewUserLogin.beSalty(this.personPassword.Text.Length);
            newPassword = createNewUserLogin.hashWithSalt($"{hashPass}{hashSalt}");
        }


        private void personBusinnessEntityID()
        {
            Repository.PersonRepository.Person person;
            using (var context = new Entities())
            {
                person = new Repository.PersonRepository.Person(context);
                this.businessEntityPersonID = person.GetPersonBusinessEntityID();
                this.businessEntityContactID = person.GetBusinessEntityID();
            }
            this.businessEntityPersonID++;
            this.businessEntityContactID++;
        }

        private void NewEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Close();
        }
    }
}
