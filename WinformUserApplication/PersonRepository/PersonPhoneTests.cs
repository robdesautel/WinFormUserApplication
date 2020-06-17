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
    public class PersonPhoneTests
    {

        [TestMethod()]
        public void GetPhoneNumberByIDsTest()
        {
            var context = new Entities();
            var personPhone = new PersonPhone(context);
            var phoneRecord = personPhone.GetPhoneNumberByIDs(10);
            Assert.AreEqual("330-555-2568", phoneRecord.PhoneNumber);
        }
    }
}