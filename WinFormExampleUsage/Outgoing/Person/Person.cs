using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExampleUsage.Outgoing.Person
{
    public class Person
    {
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
        public Address address { get; set; }
        public BusinessEntity businessEntity { get; set; }
        public BusinessEntityAddress businessEntityAddress { get; set; }
        public BusinessEntityContact businessEntityContact { get; set; }
        public EmailAddress emailAddress { get; set; }
        public PhoneNumber phoneNumber { get; set; }
        public UserPassword userPassword { get; set; }


        public virtual void saveMessage(string errorMessage = "")
        {
            string message = errorMessage;
            string caption = "contact not saved...";
            var buttons = MessageBoxButtons.OK;

            MessageBox.Show(message, caption, buttons);

        }


    }
}
