using AdventureWorksEntity.Model;
using Repository.PersonModel.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonRepository
{
    public class CountryRegion : ICountryRegion
    {
        private Entities countryRegionContext;

        public CountryRegion(Entities countryRegionContext)
        {
            this.countryRegionContext = countryRegionContext;
        }

        public IEnumerable<AdventureWorksEntity.Model.CountryRegion> countryRegions()
        {
            return countryRegionContext.CountryRegion;
        }

        public AdventureWorksEntity.Model.CountryRegion GetCountryRegionByCode(string countryRegionCode)
        {
            return countryRegionContext.CountryRegion
                .Where(c => c.CountryRegionCode.ToUpper().Equals(countryRegionCode.ToUpper())).FirstOrDefault();
        }

        public AdventureWorksEntity.Model.CountryRegion GetCountryRegionByName(string countryRegionName)
        {
            return countryRegionContext.CountryRegion
                .Where(c => c.Name.ToUpper().Equals(countryRegionName.ToUpper())).FirstOrDefault();
        }
    }
}
