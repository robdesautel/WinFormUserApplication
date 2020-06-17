using AdventureWorksEntity.Model;
using Repository.PersonModel.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonRepository
{
    public class PhoneNumberTypes : IPhoneNumberType
    {
        private Entities phoneNumberTypeContext;

        public PhoneNumberTypes(Entities phoneNumberTypeContext)
        {
            this.phoneNumberTypeContext = phoneNumberTypeContext;
        }

        public IEnumerable<PhoneNumberType> phoneNumberTypes()
        {
            return phoneNumberTypeContext.PhoneNumberType;
        }
    }
}
