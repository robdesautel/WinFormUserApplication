using AdventureWorksEntity.Model;
using Repository.PersonModel.Read;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonRepository
{
    public class EmailAddress : IEmailAddress
    {
        private Entities emailContext;

        public EmailAddress(Entities emailContext)
        {
            this.emailContext = emailContext;
        }

        public int GetEmailAddressBusinessEntityIDByEmail(string EmailAddress)
        {
            return emailContext.EmailAddress
                .Where(e => e.EmailAddress1.ToUpper().Equals(EmailAddress.ToUpper()))
                .Select(e => e.BusinessEntityID)
                .FirstOrDefault();
        }

        public AdventureWorksEntity.Model.EmailAddress GetEmailAddressByBusinessEntityID(int BusinessEntityID)
        {
            return emailContext.EmailAddress.SingleOrDefault(e => e.BusinessEntityID == BusinessEntityID);
                
        }

        public string GetEmailAddressByEmail(string EmailAddress)
        {
            return emailContext.EmailAddress
                               .Where(e => e.EmailAddress1.ToUpper().Equals(EmailAddress))
                               .Select(e => e.EmailAddress1)
                               .FirstOrDefault();
        }
    }
}
