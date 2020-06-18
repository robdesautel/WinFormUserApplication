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
    public class EmailAddressTests
    {
        [TestMethod()]
        public void GetEmailAddressByBusinessEntityIDTest()
        {
            var context = new Entities();
            Repository.PersonRepository.EmailAddress emailAddress = new EmailAddress(context);
            var emailRecord = emailAddress.GetEmailAddressByBusinessEntityID(5);

            Assert.AreEqual(5, emailRecord.BusinessEntityID);
        }
    }
}