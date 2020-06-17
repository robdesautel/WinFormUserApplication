using AdventureWorksEntity.Model;
using Repository.PersonModel.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonRepository
{
    public class PersonPhone : IPersonPhone
    {
        private Entities personPhoneContext;

        public PersonPhone(Entities personPhoneContext)
        {
            this.personPhoneContext = personPhoneContext;
        }

        public AdventureWorksEntity.Model.PersonPhone GetPhoneNumberByIDs(int BusinessEntityID)
        {
            return personPhoneContext.PersonPhone.SingleOrDefault(p => p.BusinessEntityID == BusinessEntityID);
        }
    }
}
