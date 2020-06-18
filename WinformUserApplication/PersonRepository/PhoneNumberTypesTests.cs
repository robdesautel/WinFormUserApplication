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
    public class PhoneNumberTypesTests
    {

        [TestMethod()]
        public void phoneNumberTypesTest()
        {
            var context = new Entities();
            var phoneNumberTypes = new PhoneNumberTypes(context);
            var typesOfPhoneNumbers = phoneNumberTypes.phoneNumberTypes().ToList();

            foreach (var item in typesOfPhoneNumbers)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}