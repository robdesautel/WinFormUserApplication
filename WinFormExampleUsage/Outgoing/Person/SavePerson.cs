using AdventureWorksEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExampleUsage.Outgoing.Person
{
    public class SavePerson : Person
    {
        private Entities personContext;
        

        public SavePerson(Entities personContext)
        {
            this.personContext = personContext;
        }

        public void AddBusinessEntity(List<BusinessEntity> businessEntities)
        {
            foreach (var businessEntity in businessEntities)
            {
                AddBusinessEntity(businessEntity);
            }
        }

        public void AddPerson(List<Person> people)
        {
            foreach (var person in people)
            {
                AddPerson(person);
            }
        }


        public void AddAddress(List<Address> addresses)
        {
            foreach(var address in addresses)
            {
                AddAddress(address);
            }
        }

        private void AddBusinessEntity(BusinessEntity businessEntity)
        {
            personContext.BusinessEntity.Add(new AdventureWorksEntity.Model.BusinessEntity
            {
                BusinessEntityID = businessEntity.BusinessEntityID,
                rowguid = Guid.NewGuid(),
                ModifiedDate = DateTime.Now
            });
        }

        private void AddPerson(Person person)
        {
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
                rowguid = Guid.NewGuid()

            });
        }

        private void AddAddress(Address address)
        {
            personContext.Address.Add(new AdventureWorksEntity.Model.Address
            {
                AddressLine1 = address.Address1,
                AddressLine2 = address.Address2,
                City = address.City,
                StateProvinceID = address.StateProvinceID,
                PostalCode = address.PostalCode,
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
            if (personContext.SaveChanges() > 0)
            {
                saveMessage();
                return;
            }
            base.saveMessage();
        }

        public override void saveMessage()
        {
            string message = "Contact was has been saved.";
            string caption = "Saving contact...";
            var buttons = MessageBoxButtons.OK;

            MessageBox.Show(message, caption, buttons);

        }



    }
}
