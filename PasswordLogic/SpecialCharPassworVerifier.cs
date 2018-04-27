using System.Text.RegularExpressions;

namespace PasswordLogic
{
    public class SpecialCharPassworVerifier : PasswordVerifierHandler
    {
        public override bool Verify(string password)
        {
            if (!Regex.IsMatch(password, @"[^a-zA-Z\d]"))
            {
                return false;
            }
            return successor.Verify(password);
        }
    }
}
