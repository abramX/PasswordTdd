﻿using NUnit.Framework;
using PasswordLogic;

namespace PasswordTest
{
    [TestFixture]
    public class PasswordLogicTest
    {
        PasswordVerifierHandler _nullOrEmpty;
        PasswordVerifierHandler _large8Char;
        PasswordVerifierHandler _upperCase;
        PasswordVerifierHandler _lowerCase;

        [SetUp]
        public void OnStart()
        {
            _nullOrEmpty = new NullOrEmptyPasswordVerifier();
            _large8Char = new Larger8CharPasswordVerifier();
            _upperCase = new UpperCaseCharPasswordVerifier();
            _lowerCase = new LowerCasePasswordVerifier();
            _nullOrEmpty.SetSuccessor(_large8Char);
            _large8Char.SetSuccessor(_upperCase);
            _upperCase.SetSuccessor(_lowerCase);
        }
        [TestCase("")]
        [TestCase(null)]
        [TestCase("mancaunamaiuscola")]
        [TestCase("MANCAUNAMAIUSCOLA")]
        //[TestCase("mancaUNnumero")]
        //[TestCase("mancaunCarattereSpeciale1")]
        public void TestVerifyIsFalse(string password)
        {           
            Assert.IsFalse(_nullOrEmpty.Verify(password));
        }

    }
}
