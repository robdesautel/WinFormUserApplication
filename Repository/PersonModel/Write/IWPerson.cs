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
        void InsertPerson(int BusinessEntityID,
                        string PersonType,
                        bool NameStyle,
                        string Title,
                        string FirstName,
                        string MiddleName,
                        string LastName,
                        string Suffix,
                        int EmailPromotion,
                        string AdditionalContactInfo,
                        string Demographics);

        void UpdatePerson(Person person);

        void Save();

    }
}
