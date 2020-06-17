using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksEntity.Model;

namespace Repository.PersonModel.Read
{
    interface IBusinessEntityAddress
    {
        BusinessEntityAddress GetBusinessAddressByBusinessID(int BusinessEntityID);
        int GetBusinessEntityID();
        int GetAddressID();
        int GetAddressTypeID();
        Guid Getrowguid();
        DateTime GetModifiedDate();

        //public virtual Address Address { get; set; }
        //public virtual AddressType AddressType { get; set; }
        //public virtual BusinessEntity BusinessEntity { get; set; }

    }
}
