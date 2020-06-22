using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormExampleUsage.Outgoing.Person;

namespace AdventureWorksVM
{
    public class ViewData
    {
        public ViewData(List<Person> people)
        {
            this.people = people;
        }

        public List<Person> people { get; private set; }
    }
}
