using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExampleUsage.Outgoing.Person
{
    public class Person
    {
        public Person(int businessEntityID, string personType, bool nameStyle = false, string title, string firstName, string middleName, string lastName, string suffix, bool emailPromotion)
        {
            BusinessEntityID = businessEntityID;
            PersonType = personType;
            NameStyle = nameStyle;
            Title = title;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Suffix = suffix;
            EmailPromotion = emailPromotion;
        }

        public int BusinessEntityID { get; private set; }
        public string PersonType { get; private set; }
        public bool NameStyle { get; private set; }
        public string Title { get; private set; }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string Suffix { get; private set; }
        public bool EmailPromotion { get; private set; }


    }
}
