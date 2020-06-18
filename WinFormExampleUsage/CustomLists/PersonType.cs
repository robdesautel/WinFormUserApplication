using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExampleUsage.CustomLists
{
    public class PersonType
    {
        public string personTypeName { get; private set; }

        public string personTypeCode { get; private set; }

        public PersonType(string personTypeName, string personTypeCode)
        {
            this.personTypeName = personTypeName;
            this.personTypeCode = personTypeCode;
        }

    }
}
