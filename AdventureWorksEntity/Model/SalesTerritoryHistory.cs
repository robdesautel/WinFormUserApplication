//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorksEntity.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesTerritoryHistory
    {
        public int BusinessEntityID { get; set; }
        public int TerritoryID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}
