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
        //public Person(int businessEntityID, string personType, bool nameStyle = false, string title, string firstName, string middleName, string lastName, string suffix, bool emailPromotion)
        //{
        //    BusinessEntityID = businessEntityID;
        //    PersonType = personType;
        //    NameStyle = nameStyle;
        //    Title = title;
        //    FirstName = firstName;
        //    MiddleName = middleName;
        //    LastName = lastName;
        //    Suffix = suffix;
        //    EmailPromotion = emailPromotion;
        //}

        public int BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public string Demographics { get; internal set; }
        public string AdditionalContactInformation { get; internal set; }

        public virtual void saveMessage()
        {
            string message = $"{FirstName} was not saved.";
            string caption = $"Saving {FirstName}...";
            var buttons = MessageBoxButtons.OK;

            MessageBox.Show(message, caption, buttons);

        }


    }
}
