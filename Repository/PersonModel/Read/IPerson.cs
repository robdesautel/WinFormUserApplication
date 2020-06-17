using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksEntity.Model;

namespace Repository.PersonModel.Read
{
    interface IPerson
    {
        IEnumerable<Person> GetPersons();
        Person GetPersonByFirstName(String FirstName);
        Person GetPersonByLastName(String LastName);

    }
}
