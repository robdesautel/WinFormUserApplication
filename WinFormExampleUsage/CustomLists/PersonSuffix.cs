using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormExampleUsage.CustomLists
{
    public class PersonSuffix
    {
        public PersonSuffix(string personSuffix)
        {
            this.personSuffix = personSuffix;
        }

        public string personSuffix { get; private set; }
    }
}
