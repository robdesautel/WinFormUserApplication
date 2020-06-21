using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserValidation.PasswordInteraction
{
    internal class CreatePassword : ICreatePassword
    {
        private RNGCryptoServiceProvider RNGCryptoServiceProvider;


        public string CreateHashPassword(string password)
        {
            var bytes = Encoding.ASCII.GetBytes(password);
            var hashed = SHA512.Create().ComputeHash(bytes);

            return Convert.ToBase64String(hashed);
        }

        public string CreateSalt(int byteSize)
        {
            using (RNGCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var sb = new StringBuilder();
                var data = new byte[byteSize];
                for (int i = 0; i < 3; i++)
                {
                    RNGCryptoServiceProvider.GetBytes(data);
                    var value = BitConverter.ToString(data, 0);
                    sb.Append(value);
                }
                return CreateHashPassword(sb.ToString());

            }
        }

        public string HashPasswordAndSalt(string passwordsalt)
        {
            return CreateHashPassword(passwordsalt);
        }
    }
}
