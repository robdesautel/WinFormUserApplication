using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation.PasswordInteraction
{
    public interface IValidateUser
    {
        bool IsUserName(string emailAddress);
        bool IsPasswordCorrect(string password, string emailaddress);

    }
}
