using System;

namespace PasswordLogic
{
    public abstract class PasswordVerifierHandler
    {
        protected PasswordVerifierHandler successor;
        public void SetSuccessor(PasswordVerifierHandler successor)
        {
            this.successor = successor;
        }
        public abstract bool Verify(String password);
    }
}
