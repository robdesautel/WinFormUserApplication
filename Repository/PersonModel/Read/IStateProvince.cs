using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksEntity.Model;

namespace Repository.PersonModel.Read
{
    interface IStateProvince
    {
        StateProvince GetStateProvinceByStateProvinceCode(String StateProvinceCode);
        IEnumerable<StateProvince> stateProvinces(String CountryRegionCode);
        IEnumerable<StateProvince> stateProvinces(int TerritoryID);
        StateProvince GetStateProvinceByName(String StateProvinceName);
    }
}
