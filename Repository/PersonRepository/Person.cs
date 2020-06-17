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
    public class Person : IPerson
    {
        private Entities personContext;
        public Person(Entities personContext)
        {
            this.personContext = personContext;
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
    }
}
