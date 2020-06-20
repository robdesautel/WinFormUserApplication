using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation.PasswordInteraction
{
    public interface ICreatePassword
    {
        string CreateHashPassword(string password);
        string CreateSalt(byte[] salt);
    }
}
