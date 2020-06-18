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

namespace WinFormExampleUsage
{
    public partial class NewEmployee : Form
    {
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
                var countryRegion = new Repository.PersonRepository.CountryRegion(context);
                var CountryRegion = countryRegion.countryRegions().ToList();
                this.personCountryRegion.DataSource = CountryRegion;
            }
            this.personCountryRegion.DisplayMember = "Name";
            this.personCountryRegion.ValueMember = "CountryRegionCode";
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

        private void saveContactButton_Click(object sender, EventArgs e)
        {
            int promotion = 0;

            if (this.personRecieveEmails.Checked)
            {
                promotion = 1;
            }

            using (var context = new Entities())
            {
                var personObject = new Repository.PersonRepository.Person(context);

                personObject.InsertPerson(businnessEntityID(), this.personContactInformation.SelectedValue.ToString(), false, this.personTitle.Text, this.personFirstName.Text, "", this.personLastName.Text, "", promotion, "", "");
                personObject.Save();
            }
        }

        private int businnessEntityID()
        {
            Repository.PersonRepository.Person person;
            using (var context = new Entities())
            {
                person = new Repository.PersonRepository.Person(context);
                return person.GetMaxBusinessEntityID() + 1;
            }

        }



    }
}
