using System;
using System.Text.RegularExpressions;

namespace PasswordLogic
{
    public static class PasswordVerifier
    {
       public static bool Verify(string password)
        {
            if (!String.IsNullOrEmpty(password))
            {

                if ((password.Length < 8) | (!Regex.IsMatch(password, @"[A-Z]")) | (!Regex.IsMatch(password, @"[a-z]")) | (!Regex.IsMatch(password, @"\d")) | (!Regex.IsMatch(password, @"[^a-zA-Z\d]")))
                {
                    return false;
                }
                else
                {
                    return true;
                }
                    
            }
            else
            {
                return false;
            }
            
            
        }
    }
}
