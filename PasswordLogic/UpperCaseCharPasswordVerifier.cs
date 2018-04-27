using System.Text.RegularExpressions;

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
            return successor.Verify(password);
        }
    }
}
