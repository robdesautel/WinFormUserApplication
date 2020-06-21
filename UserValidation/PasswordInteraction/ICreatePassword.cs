using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation.PasswordInteraction
{
    public interface ICreatePassword
    {
        /// <summary>
        /// takes plain text password from user.
        /// hashes the text and returns the string.
        /// </summary>
        /// <param name="password"></param>
        /// <returns>hash password</returns>
        string CreateHashPassword(string password);
        /// <summary>
        /// Generates the salt that will be added to the password.
        /// </summary>
        /// <returns>hashed bytes as a string</returns>
        string CreateSalt(int byteSize);
        /// <summary>
        /// contactenates the password and salt together to create the user password.
        /// </summary>
        /// <param name="passwordsalt"></param>
        /// <returns>final string of password to be stored</returns>
        string HashPasswordAndSalt(string passwordsalt);
    }
}
