using AdventureWorksEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation.PasswordInteraction
{
    internal class ValidateUser : IValidateUser
    {
        public bool IsPasswordCorrect(string password, string emailaddress)
        {
            string salt = "";
            string currentPassword = "";
            var validation = new CreatePassword();

            using (var context = new Entities())
            {
                var emailAddress = new Repository.PersonRepository.EmailAddress(context);
                var storedPassword = new Repository.PersonRepository.Password(context);
                var getSalt = new Repository.PersonRepository.Password(context);
                salt = getSalt.GetSaltByBussinessEntityID(emailAddress
                                                       .GetEmailAddressBusinessEntityIDByEmail(emailaddress));
                currentPassword = storedPassword
                                  .GetPasswordByBusinessEntityID(emailAddress
                                                                .GetEmailAddressBusinessEntityIDByEmail(emailaddress));
            }

            var hashPassword = validation.CreateHashPassword(password);
            var hashSaltyPassword = validation.HashPasswordAndSalt($"{hashPassword}{salt}");

            if (currentPassword != null && currentPassword.Equals(hashSaltyPassword))
            {
                return true;
            }
            return false;
        }

        public bool IsUserName(string emailAddress)
        {
            using (var context = new Entities())
            {
                var getEmailAddressBusinessID = new Repository.PersonRepository.EmailAddress(context);
                int userEmailAddressBusinessEntityID = getEmailAddressBusinessID
                                                       .GetEmailAddressBusinessEntityIDByEmail(emailAddress);
                if (userEmailAddressBusinessEntityID == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
