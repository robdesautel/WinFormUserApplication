using AdventureWorksEntity.Model;
using Repository.PersonModel.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.PersonRepository
{
    public class Address : IAddress
    {
        private Entities addressContext;

        public Address(Entities addressContext)
        {
            this.addressContext = addressContext;
        }

        public IEnumerable<AdventureWorksEntity.Model.Address> GetAddressByCity(string cityName)
        {
            return addressContext.Address.Where(a => a.City.ToUpper().Equals(cityName.ToUpper()));
        }

        public int GetNumberOfAddressID()
        {
            return addressContext.Address.Max(a => a.AddressID);
        }
    }
}
