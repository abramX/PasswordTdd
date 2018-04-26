﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordLogic
{
    public static class PasswordVerifier
    {
       public static bool Verify(string password)
        {
            if (!String.IsNullOrEmpty(password))
            {
                //bool prova = Regex.IsMatch(password, @"[A-Z]");
                //string provastringa= Regex.Match(password, @"[A-Z]").ToString();
                if ((password.Length < 8) | (!Regex.IsMatch(password, @"[A-Z]")))
                {
                    return false;
                }
                else
                {
                    return true;
                }
                    
            }
            else
            {
                return false;
            }
            
            
        }
    }
}
