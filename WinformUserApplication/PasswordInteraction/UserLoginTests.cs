using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation.PasswordInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation.PasswordInteraction.Tests
{
    [TestClass()]
    public class UserLoginTests
    {
        [TestMethod()]
        public void newPasswordTest()
        {
            var userLogin = new UserLogin();

            var userPassword = userLogin.newPassword("Password");
            Console.WriteLine(userPassword);
        }
    }
}