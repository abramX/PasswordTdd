namespace PasswordLogic
{
    public class Larger8CharPasswordVerifier : PasswordVerifierHandler
    {
        public override bool Verify(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }           
            return successor.Verify(password);
        }
    }
}
