using AdventureWorksEntity.Model;
using Repository.PersonModel.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonRepository
{
    public class StateProvince : IStateProvince
    {
        private Entities stateProvinceContext;

        public StateProvince(Entities stateProvinceContext)
        {
            this.stateProvinceContext = stateProvinceContext;
        }

        public AdventureWorksEntity.Model.StateProvince GetStateProvinceByName(string StateProvinceName)
        {
            return stateProvinceContext.StateProvince
                                        .Where(s => s.Name.ToUpper().Equals(StateProvinceName.ToUpper())).FirstOrDefault();
        }

        public AdventureWorksEntity.Model.StateProvince GetStateProvinceByStateProvinceCode(string StateProvinceCode)
        {
            return stateProvinceContext.StateProvince
                .Where(s => s.StateProvinceCode.ToUpper().Equals(StateProvinceCode.ToUpper())).FirstOrDefault();
        }

        public IEnumerable<AdventureWorksEntity.Model.StateProvince> stateProvinces(string CountryRegionCode)
        {
            return stateProvinceContext.StateProvince
                .Where(s => s.CountryRegionCode.ToUpper().Equals(CountryRegionCode.ToUpper()));
        }

        public IEnumerable<AdventureWorksEntity.Model.StateProvince> stateProvinces(int TerritoryID)
        {
            return stateProvinceContext.StateProvince
                .Where(s => s.TerritoryID == TerritoryID);
        }

        public IEnumerable<AdventureWorksEntity.Model.StateProvince> stateProvinces()
        {
            return stateProvinceContext.StateProvince;
        }
    }
}
