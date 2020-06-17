using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksEntity.Model;

namespace Repository.PersonModel.Read
{
    interface IPassword
    {
        BusinessEntity GetPasswordByBussinessEntityID(int BusinesseEntityID);
        string GetPasswordHash();
        string GetPasswordSalt();
        Guid Getrowguid();
        int GetBusinessEntityID();
        DateTime GetModifiedDate();

        //public virtual Person Person { get; set; }

    }
}
