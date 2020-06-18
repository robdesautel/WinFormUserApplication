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
        public Address(string address1, string address2, string city, int stateProvinceID, int postalCode)
        {
            Address1 = address1;
            Address2 = address2;
            City = city;
            StateProvinceID = stateProvinceID;
            PostalCode = postalCode;
        }

        public string Address1 { get; private set; }
        public string Address2 { get; private set; }
        public string City { get; private set; }

        public int StateProvinceID { get; private set; }
        public int PostalCode { get; private set; }


    }
}
