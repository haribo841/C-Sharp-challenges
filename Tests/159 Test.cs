using System;
using Challenges;
using Microsoft.Diagnostics.Runtime.Utilities;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests159
    {
        [Test]
        [TestCase("59001", true)]
        [TestCase("853a7", false)]
        [TestCase("732 32", false)]
        [TestCase("788876", false)]
        [TestCase("a923b", false)]
        [TestCase("5923!", false)]
        [TestCase("59238aa", false)]
        [TestCase("88231", true)]
        public void FixedTest(string zip, bool expectedResult)
        {
            bool result = Program159.IsValid(zip);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}