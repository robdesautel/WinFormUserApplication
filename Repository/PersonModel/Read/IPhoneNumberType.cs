using AdventureWorksEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonModel.Read
{
    interface IPhoneNumberType
    {
        IEnumerable<PhoneNumberType> phoneNumberTypes();
    }
}
