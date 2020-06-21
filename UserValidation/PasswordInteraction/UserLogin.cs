using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation.PasswordInteraction
{
    public class UserLogin
    {
        private CreatePassword CreatePassword;

        public UserLogin()
        {
            CreatePassword = new CreatePassword();
        }

        public string newPassword(String password)
        {
            return CreatePassword.CreateHashPassword(password);
        }

        public string beSalty(int byteSize)
        {
            return CreatePassword.CreateSalt(byteSize);
        }

        public string hashWithSalt(string hashWithSalt)
        {
           return CreatePassword.HashPasswordAndSalt(hashWithSalt);
        }
        
    }
}
