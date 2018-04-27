﻿using System.Text.RegularExpressions;

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
            else if (successor != null)
            {
                return successor.Verify(password);
            }
            return true;
        }
    }
}
