using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorksEntity.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.PersonRepository;

namespace WinformUserApplication
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task getPersonByFirstName()
        {
            var context = new Entities();
            Repository.PersonRepository.Person person = new Repository.PersonRepository.Person(context);
            var test = await person.GetPersonByFirstNameAsync("John");
            Assert.AreEqual("John", test.FirstName);
        }

        [TestMethod]
        public async Task getListOfBusinesses()
        {
            var context = new Entities();
            Repository.PersonRepository.Person person = new Repository.PersonRepository.Person(context);
            var test  = await person.GetPersonByLastNameAsync("Smith");
            Assert.AreEqual("Smith", test.LastName);
        }

        [TestMethod]
        public void getListOfPerson()
        {
            var context = new Entities();
            Repository.PersonRepository.Person person = new Repository.PersonRepository.Person(context);
            var items = person.GetPersons();
            //returns object of AdventureWorks.Model.Person and prints values in model.
            foreach(var item in items)
            {
                Console.WriteLine(item.FirstName);
            }
        }

        [TestMethod]
        public void getListOfAddress()
        {
            var context = new Entities();
            Repository.PersonRepository.Address address = new Repository.PersonRepository.Address(context);
            var items = address.GetAddressByCity("Seattle");
            //returns List<AdventureWorks.Model.Addres> and validates that Seattle was expected.
            foreach (var item in items)
            {
                Assert.AreEqual("Seattle", item.City);
            }
        }

        [TestMethod]
        public void getIEnumberableOfAddressType()
        {
            var context = new Entities();
            Repository.PersonRepository.AddressType addressType = new Repository.PersonRepository.AddressType(context);
            var items = addressType.addressTypes().ToList();
            //returns IEnumberable<AdventureWorks.Model.Person> and prints values in model.
            foreach (var item in items)
            {
                if (!item.Equals("Billing"))
                {
                    continue;
                }
                Assert.AreEqual("Billing", item.Name);
            }
        }

        [TestMethod]
        public void getIEnumberableOfContactType()
        {
            var context = new Entities();
            Repository.PersonRepository.ContactType contactType = new Repository.PersonRepository.ContactType(context);
            var items = contactType.contactTypes().ToList();
            //returns IEnumberable<AdventureWorks.Model.ContactType> and validate value in model.
            foreach (var item in items)
            {
                if (!item.Equals("Accounting Manager"))
                {
                    continue;
                }
                Assert.AreEqual("Accounting Manager", item.Name);
            }
        }

    }
}
