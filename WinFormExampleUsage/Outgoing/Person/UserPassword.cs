using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormExampleUsage.Outgoing.Person
{
    public class UserPassword
    {
        public int BusinessEntityID { get; set; }

        public string PasswordSaltyHas { get; set; }

        public string Salt { get; set; }

    }
}
