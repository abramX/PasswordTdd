using System;

namespace PasswordLogic
{
    public class NullOrEmptyPasswordVerifier : PasswordVerifierHandler
    {
        public override bool Verify(string password)
        {
            if (String.IsNullOrEmpty(password))
            {
                return false;
            }else if (successor != null)
            {
                return successor.Verify(password);
            }
            return true;
        }
    }
}
