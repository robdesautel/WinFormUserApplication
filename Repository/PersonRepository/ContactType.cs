using AdventureWorksEntity.Model;
using Repository.PersonModel.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonRepository
{
    public class ContactType : IContactType
    {
        private Entities contactTypeEntities;

        public ContactType(Entities contactTypeEntities)
        {
            this.contactTypeEntities = contactTypeEntities;
        }

        public IEnumerable<AdventureWorksEntity.Model.ContactType> contactTypes()
        {
            return contactTypeEntities.ContactType;
        }
    }
}
