using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksEntity.Model;

namespace Repository.PersonModel.Read
{
    interface IBusinessEntity
    {
        IEnumerable GetBusinesses();
        BusinessEntity GetBusinessByID(int BuisnessEntityID);
        int GetBusinessEntityID();
        Guid Getrowguid();
        DateTime GetModifiedDate();

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
        //public virtual Person Person { get; set; }
        //public virtual Store Store { get; set; }
        //public virtual Vendor Vendor { get; set; }

    }
}
