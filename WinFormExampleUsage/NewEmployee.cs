﻿using AdventureWorksEntity.Model;
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
        private List<Outgoing.Person.Person> people;
        private List<Outgoing.Person.BusinessEntity> businessEntities;
        private List<Outgoing.Person.Address> addresses;

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
            savePerson.AddBusinessEntity(this.businessEntities);
            savePerson.AddPerson(people);
            savePerson.AddAddress(addresses);
            savePerson.InsertPerson();
        }


        private void addNewPerson()
        {
            people = new List<Outgoing.Person.Person>();
            businessEntities = new List<Outgoing.Person.BusinessEntity>();

            int businessEntityID = businnessEntityID();
            int emailPromotion = 0;
            if (this.personRecieveEmails.Checked)
            {
                emailPromotion = 1;
            }

            businessEntities.Add(new Outgoing.Person.BusinessEntity
            {
                BusinessEntityID = businessEntityID
            });

            people.Add(new Outgoing.Person.Person
            {
                BusinessEntityID = businessEntityID,
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
            addNewPersonAddress();
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
