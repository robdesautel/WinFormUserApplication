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

        public AdventureWorksEntity.Model.EmailAddress GetEmailAddressByBusinessEntityID(int BusinessEntityID)
        {
            return emailContext.EmailAddress.SingleOrDefault(e => e.BusinessEntityID == BusinessEntityID);
                
        }
    }
}
