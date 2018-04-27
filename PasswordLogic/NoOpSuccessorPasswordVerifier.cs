namespace PasswordLogic
{
    public class NoOpSuccessorPasswordVerifier : PasswordVerifierHandler
    {
        public override bool Verify(string password)
        {
            return true;
        }
    }
}
