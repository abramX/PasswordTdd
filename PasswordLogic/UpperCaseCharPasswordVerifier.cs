using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordLogic
{
    public class UpperCaseCharPasswordVerifier : PasswordVerifierHandler
    {
        public override bool Verify(string password)
        {
            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                return false;
            }
            else if (successor != null)
            {
                return successor.Verify(password);
            }
            return true;
        }
    }
}
