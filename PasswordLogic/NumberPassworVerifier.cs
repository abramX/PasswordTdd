using System.Text.RegularExpressions;

namespace PasswordLogic
{
    public class NumberPassworVerifier : PasswordVerifierHandler
    {
        public override bool Verify(string password)
        {
            if (!Regex.IsMatch(password, @"\d"))
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
