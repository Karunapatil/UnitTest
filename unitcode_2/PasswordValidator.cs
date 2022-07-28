using System;
using System.Linq;

namespace UnitTest
{
    public class PasswordValidator
    {

        public bool PasswordLength(string password)
        {
            if (password.Count() >= 7 && password.Count() <= 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
