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
        public void TestClassVerify(string password)
        {           
            Assert.IsFalse(PasswordVerifier.Verify(password));
        }
    }
}
