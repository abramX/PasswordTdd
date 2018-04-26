using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordLogic
{
    public static class PasswordVerifier
    {
       public static bool Verify(string password)
        {
            if (password.Length < 8)
                return false;
            return true;
        }
    }
}
