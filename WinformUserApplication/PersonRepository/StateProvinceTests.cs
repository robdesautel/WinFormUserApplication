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
    public class StateProvinceTests
    {

        [TestMethod()]
        public void GetStateProvinceByNameTest()
        {
            var context = new Entities();
            var stateProvince = new StateProvince(context);
            var stateProvinceName = stateProvince.GetStateProvinceByName("Alberta");
            Assert.AreEqual("Alberta", stateProvinceName.Name);
        }

        [TestMethod()]
        public void GetStateProvinceByStateProvinceCodeTest()
        {
            var context = new Entities();
            var stateProvince = new StateProvince(context);
            var stateProvinceName = stateProvince.GetStateProvinceByStateProvinceCode("AL");
            Assert.AreEqual("AL", stateProvinceName.StateProvinceCode.Trim());
        }

        [TestMethod()]
        public void stateProvincesByTerritoryIDTest()
        {
            var context = new Entities();
            var stateProvince = new StateProvince(context);
            var stateProvinceNames = stateProvince.stateProvinces(5).ToList();

            foreach (var stateprovince in stateProvinceNames)
            {
                Console.WriteLine(stateprovince.Name);
            }
        }

        [TestMethod()]
        public void stateProvincesTest1()
        {
            var context = new Entities();
            var stateProvince = new StateProvince(context);
            var stateProvinceNames = stateProvince.stateProvinces("US").ToList();

            foreach (var stateprovince in stateProvinceNames)
            {
                Console.WriteLine(stateprovince.Name);
            }

        }
    }
}