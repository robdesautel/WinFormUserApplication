using AdventureWorksEntity.Model;
using Repository.PersonRepository;
using WinFormExampleUsage.CustomLists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using WinFormExampleUsage.Outgoing.Person;
using System.Runtime.CompilerServices;

namespace WinFormExampleUsage
{
    public partial class NewEmployee : Form
    {
        private List<Outgoing.Person.Person> people;
        private List<Outgoing.Person.BusinessEntity> businessEntities;
        private List<Outgoing.Person.Address> addresses;
        private List<Outgoing.Person.BusinessEntityContact> businessEntityContacts;
        private List<Outgoing.Person.BusinessEntityAddress> businessEntityAddresses;
        private List<Outgoing.Person.EmailAddress> emailAddresses;
        private List<Outgoing.Person.PhoneNumber> phoneNumbers;
        private int businessEntityPersonID;
        private int businessEntityContactID;
        private int addressID;
        public NewEmployee()
        {
            InitializeComponent();
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
            savePerson.AddBusinessEntity(businessEntities);
            savePerson.AddPerson(people);
            savePerson.AddAddress(addresses);
            savePerson.AddBusinessEntityContact(businessEntityContacts);
            savePerson.AddBusinessEntityEmailAddress(emailAddresses);
            savePerson.AddPhoneNumber(phoneNumbers);
            savePerson.InsertPerson();
        }


        private void addNewPerson()
        {
            people = new List<Outgoing.Person.Person>();
            businessEntities = new List<Outgoing.Person.BusinessEntity>();

            int emailPromotion = 0;
            if (this.personRecieveEmails.Checked)
            {
                emailPromotion = 1;
            }

            businessEntities.Add(new Outgoing.Person.BusinessEntity
            {
                BusinessEntityID = this.businessEntityPersonID
            });

            people.Add(new Outgoing.Person.Person
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
                AdditionalContactInformation = null
            });
            businessEntityAddressID();
            addNewPersonAddress();
            addNewBusinessEntityContact();
            addNewBusinessAddress();
            addNewEmailAddress();
            addPhoneNumber();
        }

        private void addNewPersonAddress()
        {
            addresses = new List<Outgoing.Person.Address>();
            addresses.Add(new Outgoing.Person.Address
            {
                Address1 = this.personAddress1.Text,
                Address2 = this.personAddress1.Text,
                StateProvinceID = (int)this.personStateProvince.SelectedValue,
                City = this.personCity.Text,
                PostalCode = this.personZipCode.Text
            });
        }

        private void addNewBusinessEntityContact()
        {
            businessEntityContacts = new List<Outgoing.Person.BusinessEntityContact>();
            businessEntityContacts.Add(new Outgoing.Person.BusinessEntityContact
            {
                BusinessEntityID = this.businessEntityContactID,
                ContactTypeID = (int)this.personContactTypes.SelectedValue,
                PersonID = this.businessEntityPersonID
            });

        }

        private void addNewBusinessAddress()
        {
            businessEntityAddresses = new List<Outgoing.Person.BusinessEntityAddress>();
            businessEntityAddresses.Add(new Outgoing.Person.BusinessEntityAddress
            {
                AddressID = this.addressID++,
                BusinessEntityID = this.businessEntityPersonID,
                AddressTypeID = (int)this.personAddressType.SelectedValue
            });
        }

        private void addNewEmailAddress()
        {
            emailAddresses = new List<Outgoing.Person.EmailAddress>();
            emailAddresses.Add(new Outgoing.Person.EmailAddress
            {
                emailAddress = this.personEmailAddress.Text,
                BusinessEntityID = this.businessEntityPersonID

            });
        }

        private void addPhoneNumber()
        {
            phoneNumbers = new List<PhoneNumber>();
            phoneNumbers.Add(new PhoneNumber
            {
                BusinessEntityID = this.businessEntityPersonID,
                PersonPhoneNumber = this.personPhoneNumber.Text,
                PhoneNumberType = (int)this.cellPhoneTypes.SelectedValue
            });
        }



        private void businessEntityAddressID()
        {
            Repository.PersonRepository.Address address;
            using (var context = new Entities())
            {
                address = new Repository.PersonRepository.Address(context);
                this.addressID = address.GetNumberOfAddressID();
            }
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

    }
}
