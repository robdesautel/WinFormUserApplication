using AdventureWorksEntity.Model;
using Repository.PersonModel.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonRepository
{
    public class AddressType : IAddressType
    {
        private Entities addressTypeContext;

        public AddressType(Entities addressTypeContext)
        {
            this.addressTypeContext = addressTypeContext;
        }

        public IEnumerable<AdventureWorksEntity.Model.AddressType> addressTypes()
        {
            return addressTypeContext.AddressType;
        }
    }
}
