using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksEntity.Model;

namespace Repository.PersonModel.Read
{
    interface IBusinessEntityContact
    {
        /// <summary>
        /// Gets the max number of records from Person.BusinessEntity
        /// </summary>
        /// <returns>max number of records from Person.BusinessEntity</returns>
        int GetBusinessEntityID();
        /// <summary>
        /// Gets the max number of records from Person.Person
        /// </summary>
        /// <returns>max number of records from Person.Person</returns>
        int GetPersonBusinessEntityID();
    }
}
