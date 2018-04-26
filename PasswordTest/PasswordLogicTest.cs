using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordLogic;

namespace PasswordTest
{
    [TestFixture]
    public class PasswordLogicTest
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("mancaunamaiuscola")]
        [TestCase("MANCAUNAMAIUSCOLA")]
        public void TestVerifyIsFalse(string password)
        {           
            Assert.IsFalse(PasswordVerifier.Verify(password));
        }

    }
}
