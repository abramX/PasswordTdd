﻿namespace PasswordLogic
{
    public class Larger8CharPasswordVerifier : PasswordVerifierHandler
    {
        public override bool Verify(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            else if(successor!=null)
            {
                return successor.Verify(password);
            }
           
            return false;
        }
    }
}
