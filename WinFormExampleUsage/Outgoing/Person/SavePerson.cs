using AdventureWorksEntity.Model;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExampleUsage.Outgoing.Person
{
    public class SavePerson : Person
    {
        private Entities personContext;
        private List<AdventureWorksEntity.Model.BusinessEntityAddress> businessEntityAddresses;
        private List<AdventureWorksEntity.Model.BusinessEntityContact> businessEntityContacts;
        private List<AdventureWorksEntity.Model.EmailAddress> emailAddresses;

        public SavePerson()
        {
            businessEntityAddresses = new List<AdventureWorksEntity.Model.BusinessEntityAddress>();
            businessEntityContacts = new List<AdventureWorksEntity.Model.BusinessEntityContact>();
            emailAddresses = new List<AdventureWorksEntity.Model.EmailAddress>();
        }

        public SavePerson(Entities personContext) : this()
        {
            this.personContext = personContext;
        }

        public void AddPerson(List<Person> people)
        {
            foreach (var person in people)
            {
                AddPerson(person);
            }
        }

        public void AddPerson(Person person)
        {

            businessEntityAddresses.Add(new AdventureWorksEntity.Model.BusinessEntityAddress
            {
                BusinessEntityID = person.BusinessEntityID,
                AddressID = person.businessEntityAddress.AddressID,
                AddressTypeID = person.businessEntityAddress.AddressTypeID,
                rowguid = Guid.NewGuid(),
                ModifiedDate = DateTime.Now
            });

            businessEntityContacts.Add(new AdventureWorksEntity.Model.BusinessEntityContact
            {
                BusinessEntityID = person.businessEntityContact.BusinessEntityID,
                PersonID = person.businessEntityContact.PersonID,
                ContactTypeID = person.businessEntityContact.ContactTypeID,
                rowguid = Guid.NewGuid(),
                ModifiedDate = DateTime.Now

            });

            emailAddresses.Add(new AdventureWorksEntity.Model.EmailAddress
            {
                BusinessEntityID = person.emailAddress.BusinessEntityID,
                EmailAddress1 = person.emailAddress.emailAddress,
                rowguid = Guid.NewGuid(),
                ModifiedDate = DateTime.Now
            });

            personContext.Person.Add(new AdventureWorksEntity.Model.Person
            {
                BusinessEntityID = person.BusinessEntityID,
                PersonType = person.PersonType,
                NameStyle = person.NameStyle,
                Title = person.Title,
                FirstName = person.FirstName,
                MiddleName = person.MiddleName,
                LastName = person.LastName,
                Suffix = person.Suffix,
                EmailPromotion = person.EmailPromotion,
                AdditionalContactInfo = person.AdditionalContactInformation,
                Demographics = person.Demographics,
                ModifiedDate = DateTime.Now,
                rowguid = Guid.NewGuid(),
                BusinessEntity = new AdventureWorksEntity.Model.BusinessEntity
                {
                    BusinessEntityID = person.BusinessEntityID,
                    rowguid = Guid.NewGuid(),
                    ModifiedDate = DateTime.Now,
                    BusinessEntityAddress = businessEntityAddresses,
                },
                BusinessEntityContact = businessEntityContacts,
                EmailAddress = emailAddresses,
                Password = new Password
                {
                    BusinessEntityID = person.userPassword.BusinessEntityID,
                    PasswordHash = person.userPassword.PasswordSaltyHas,
                    PasswordSalt = person.userPassword.Salt,
                    ModifiedDate = DateTime.Now,
                    rowguid = Guid.NewGuid()

                },
                
                
            });

            personContext.Address.Add(new AdventureWorksEntity.Model.Address
            {
                AddressLine1 = person.address.Address1,
                AddressLine2 = person.address.Address2,
                City = person.address.City,
                StateProvinceID = person.address.StateProvinceID,
                PostalCode = person.address.PostalCode,
                SpatialLocation = null,
                rowguid = Guid.NewGuid(),
                ModifiedDate = DateTime.Now
            });
        }

        public void InsertPerson()
        {
            Save();
        }

        private void Save()
        {
                personContext.SaveChanges();
            
                saveMessage();
        }

        public override void saveMessage(string errorMessage = "")
        {
            string message = "Contact was has been saved.";
            string caption = "Saving contact...";
            var buttons = MessageBoxButtons.OK;

            MessageBox.Show(message, caption, buttons);

        }



    }
}
