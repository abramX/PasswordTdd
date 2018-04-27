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
            return successor.Verify(password);
        }
    }
}
