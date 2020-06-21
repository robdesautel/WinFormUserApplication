using AdventureWorksEntity.Model;
using Repository.PersonModel.Read;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonRepository
{
    public class Password : IPassword
    {
        private Entities passwordContext;

        public Password(Entities passwordContext)
        {
            this.passwordContext = passwordContext;
        }

        public string GetPasswordByBusinessEntityID(int BusinessEntityID)
        {
            return passwordContext.Password
                                  .Where(p => p.BusinessEntityID == BusinessEntityID)
                                  .Select(p => p.PasswordHash)
                                  .FirstOrDefault();
        }

        public string GetSaltByBussinessEntityID(int BusinesseEntityID)

        {
            return this.passwordContext.Password.Where(p => p.BusinessEntityID == BusinesseEntityID).Select(p => p.PasswordSalt).FirstOrDefault();
        }
    }
}
