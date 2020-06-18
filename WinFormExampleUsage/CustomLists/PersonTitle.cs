using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormExampleUsage.CustomLists
{
    public class PersonTitle
    {
        public PersonTitle(string titleName)
        {
            this.titleName = titleName;
        }

        public string titleName { get; private set; }
    }
}
