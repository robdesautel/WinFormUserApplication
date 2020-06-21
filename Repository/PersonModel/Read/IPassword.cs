using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksEntity.Model;

namespace Repository.PersonModel.Read
{
    interface IPassword
    {
        string GetSaltByBussinessEntityID(int BusinesseEntityID);

        string GetPasswordByBusinessEntityID(int BusinessEntityID);
    }
}
