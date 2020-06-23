using AdventureWorksEntity.Model;
using Repository.PersonModel.Read;
using Repository.PersonModel.Write;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonRepository
{
    public class Person : IPerson, IBuinessIdentityID, IWPerson, IBusinessEntityContact
    {
        public Entities personContext;
        public Person(Entities personContext)
        {
            this.personContext = personContext;
        }

        public async Task<int> GetMaxBusinessEntityIDAsync()
        {
            return await personContext.BusinessEntity.MaxAsync(i => i.BusinessEntityID);
        }

        // the name Person is ambigious
        public async Task<AdventureWorksEntity.Model.Person> GetPersonByFirstNameAsync(string FirstName)
        {
            return await personContext.Person.Where(p => p.FirstName.ToUpper().Equals(FirstName.ToUpper())).FirstOrDefaultAsync();
        }

        // the name Person is ambigious
        public async Task<AdventureWorksEntity.Model.Person> GetPersonByLastNameAsync(string LastName)
        {
            return await personContext.Person.Where(p => p.LastName.ToUpper().Equals(LastName.ToUpper())).FirstOrDefaultAsync();
        }

        public IEnumerable<AdventureWorksEntity.Model.Person> GetPersons()
        {
            return personContext.Person;
        }


        public void InsertPerson(int BusinessEntityID,
                                 string PersonType,
                                 bool NameStyle,
                                 string Title,
                                 string FirstName,
                                 string MiddleName,
                                 string LastName,
                                 string Suffix,
                                 int EmailPromotion,
                                 string AdditionalContactInfo,
                                 string Demographics)
        {
            personContext.BusinessEntity.Add(new BusinessEntity
            {
                BusinessEntityID = BusinessEntityID,
                ModifiedDate = DateTime.Now
            });

            personContext.Person.Add(new AdventureWorksEntity.Model.Person
            {
                BusinessEntityID = BusinessEntityID,
                PersonType = PersonType,
                NameStyle = NameStyle,
                Title = Title,
                FirstName = FirstName,
                MiddleName = MiddleName,
                LastName = LastName,
                Suffix = Suffix,
                EmailPromotion = EmailPromotion,
                AdditionalContactInfo = AdditionalContactInfo,
                Demographics = Demographics,
                ModifiedDate = DateTime.Now,
            });
        }
        

        public void UpdatePerson(AdventureWorksEntity.Model.Person person)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            personContext.SaveChanges();
        }
        public int GetBusinessEntityID()
        {
            return personContext.BusinessEntity.Max(s => s.BusinessEntityID);
        }
        public int GetPersonBusinessEntityID()
        {
            return personContext.Person.Max(s => s.BusinessEntityID);
        }
    }
    
}
