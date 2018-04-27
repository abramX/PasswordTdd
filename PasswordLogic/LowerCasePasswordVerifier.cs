using System.Text.RegularExpressions;

namespace PasswordLogic
{
    public class LowerCasePasswordVerifier : PasswordVerifierHandler
    {
        public override bool Verify(string password)
        {
            if (!Regex.IsMatch(password, @"[a-z]"))
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
