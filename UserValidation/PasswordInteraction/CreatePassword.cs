using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation.PasswordInteraction
{
    internal class CreatePassword : ICreatePassword
    {

        public string CreateHashPassword(string password)
        {
            throw new NotImplementedException();
        }

        public string CreateSalt(byte[] salt)
        {
            throw new NotImplementedException();
        }
    }
}
