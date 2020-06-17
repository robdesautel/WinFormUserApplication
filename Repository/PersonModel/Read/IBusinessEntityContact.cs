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
        BusinessEntityContact GetBusinessContactByBusinessID(int BusinessEntityID);
        int GetBusinessEntityID();
        int GetPersonID();
        int GetContactTypeID();
        Guid Getrowguid();
        DateTime GettModifiedDate();

        //public virtual BusinessEntity BusinessEntity { get; set; }
        //public virtual ContactType ContactType { get; set; }
        //public virtual Person Person { get; set; }

    }
}
