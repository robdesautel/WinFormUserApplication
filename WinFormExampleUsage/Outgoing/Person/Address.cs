using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WinFormExampleUsage.Outgoing.Person
{
    public class Address
    {

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int StateProvinceID { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

    }
}
