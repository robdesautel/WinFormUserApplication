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
    public class PasswordTests
    {
        private string SALT = "yz0y3BPXoKx1aNzOssskodzhzZBZR6fm5Y4v6J5jrCYu8w8kyLO62/qPoV5fFQVbbj5bVH7QfeRfkp+yzN4fuQ==";
        [TestMethod()]
        public void GetPasswordByBussinessEntityIDTest()
        {
            Entities context = new Entities();
            Password getPassword = new Password(context);

            var userPassword = getPassword.GetSaltByBussinessEntityID(20798);

            Assert.AreEqual(SALT, userPassword);
        }
    }
}