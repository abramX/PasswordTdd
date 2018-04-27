using NUnit.Framework;
using PasswordLogic;

namespace PasswordTest
{
    [TestFixture]
    public class PasswordLogicTest
    {
        PasswordVerifierHandler _nullOrEmpty;
        PasswordVerifierHandler _large8Char;

        [SetUp]
        public void OnStart()
        {
            _nullOrEmpty = new NullOrEmptyPasswordVerifier();
            _large8Char = new Larger8CharPasswordVerifier();
            _nullOrEmpty.SetSuccessor(_large8Char);
        }
        [TestCase("")]
        [TestCase(null)]
        //[TestCase("mancaunamaiuscola")]
        //[TestCase("MANCAUNAMAIUSCOLA")]
        //[TestCase("mancaUNnumero")]
        //[TestCase("mancaunCarattereSpeciale1")]
        public void TestVerifyIsFalse(string password)
        {           
            Assert.IsFalse(_nullOrEmpty.Verify(password));
        }

    }
}
