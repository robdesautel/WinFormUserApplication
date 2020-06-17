using AdventureWorksEntity.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.PersonRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonRepository.Tests
{
    [TestClass()]
    public class CountryRegionTests
    {
        [TestMethod()]
        public void IEnumberableOfCountryRegionTest()
        {
            var context = new Entities();
            CountryRegion countryRegion = new CountryRegion(context);
            var items = countryRegion.countryRegions().ToList();

            foreach (var item in items)
            { 
                if (!item.CountryRegionCode.Equals("AD"))
                {
                    continue;
                }
                Assert.AreEqual("AD", item.CountryRegionCode);
            }

        }
        [TestMethod()]
        public void GetCountryRegionByCodeTest()
        {
            var context = new Entities();
            Repository.PersonRepository.CountryRegion countryRegion = new Repository.PersonRepository.CountryRegion(context);
            var cr = countryRegion.GetCountryRegionByCode("AD");
            Assert.AreEqual("AD", cr.CountryRegionCode);
        }

        [TestMethod()]
        public void GetCountryRegionByNameTest()
        {
            var context = new Entities();
            CountryRegion countryRegion = new CountryRegion(context);
            var cr = countryRegion.GetCountryRegionByName("Andorra");
            Assert.AreEqual("Andorra", cr.Name);

        }
    }
}