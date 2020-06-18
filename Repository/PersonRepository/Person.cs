using AdventureWorksEntity.Model;
using Repository.PersonModel.Read;
using Repository.PersonModel.Write;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonRepository
{
    public class Person : IPerson, IBuinessIdentityID, IWPerson
    {
        private Entities personContext;
        public Person(Entities personContext)
        {
            this.personContext = personContext;
        }

        public int GetMaxBusinessEntityID()
        {
            return personContext.BusinessEntity.Max(i => i.BusinessEntityID);
        }

        // the name Person is ambigious
        public AdventureWorksEntity.Model.Person GetPersonByFirstName(string FirstName)
        {
            return personContext.Person.Where(p => p.FirstName.ToUpper().Equals(FirstName.ToUpper())).FirstOrDefault();
        }

        // the name Person is ambigious
        public AdventureWorksEntity.Model.Person GetPersonByLastName(string LastName)
        {
            return personContext.Person.Where(p => p.LastName.ToUpper().Equals(LastName.ToUpper())).FirstOrDefault();
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

    }
}
