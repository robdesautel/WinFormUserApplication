using AdventureWorksEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.PersonModel.Write
{
    interface IWPerson
    {
        void InsertPerson(Person person,
                  Address address,
                  AddressType addressType,
                  BusinessEntity businessEntity,
                  BusinessEntityAddress businessEntityAddress,
                  BusinessEntityContact businessEntityContact,
                  ContactType contactType,
                  CountryRegion countryRegion,
                  EmailAddress email,
                  Password password,
                  PersonPhone personPhone,
                  PhoneNumberType phoneNumberType,
                  StateProvince stateProvince);

        void UpdatePerson(Person person = null,
                          Address address = null,
                          AddressType addressType = null,
                          BusinessEntity businessEntity = null,
                          BusinessEntityAddress businessEntityAddress = null,
                          BusinessEntityContact businessEntityContact = null,
                          ContactType contactType = null,
                          CountryRegion countryRegion = null,
                          EmailAddress email = null,
                          Password password = null,
                          PersonPhone personPhone = null,
                          PhoneNumberType phoneNumberType = null,
                          StateProvince stateProvince = null);

        void Save();

    }
}
