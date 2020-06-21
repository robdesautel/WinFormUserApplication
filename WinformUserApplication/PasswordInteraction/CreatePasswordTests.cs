//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using UserValidation.PasswordInteraction;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UserValidation.PasswordInteraction.Tests
//{
//    [TestClass()]
//    public class CreatePasswordTests
//    {
//        [TestMethod()]
//        public void CreateHashPasswordTest()
//        {
//            var password = new CreatePassword();
//            Console.WriteLine(password.CreateHashPassword("password"));
//        }

//        [TestMethod()]
//        public void CreateSaltTest()
//        {
//            var salt = new CreatePassword();

//            Console.WriteLine(salt.CreateSalt());
//        }

//        [TestMethod()]
//        public void HashPasswordAndSaltTest()
//        {
//            var password = new CreatePassword();
//            var userPassword = password.CreateHashPassword("testingPassWord2020");
//            var salting = password.CreateSalt();

//            var insertPassword = password.HashPasswordAndSalt(string.Format($"{userPassword}{salting}"));
//            Console.WriteLine("salt = " + salting);
//            Console.WriteLine("password = " + insertPassword);
//        }
//    }
//}