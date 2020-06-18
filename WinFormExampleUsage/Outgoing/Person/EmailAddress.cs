using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormExampleUsage.Outgoing.Person
{
    public class EmailAddress
    {
        public EmailAddress(int businessEntityID, string emailAddress)
        {
            BusinessEntityID = businessEntityID;
            this.emailAddress = emailAddress;
        }

        public int BusinessEntityID { get; private set; }
        public string emailAddress { get; private set; }

    }
}
