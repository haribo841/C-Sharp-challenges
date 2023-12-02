using System;
using Challenges.Edabit;
using Microsoft.Diagnostics.Runtime.Utilities;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests151
    {
        [Test]
        [TestCase("mom", true)]
        [TestCase("scary", false)]
        [TestCase("reviver", true)]
        [TestCase("stressed", false)]
        [TestCase("good", false)]
        [TestCase("refer", true)]
        [TestCase("something", false)]
        [TestCase("redder", true)]
        [TestCase("civic", true)]
        public void FixedTest(string str, bool expectedResult)
        {
            bool result = Program151.CheckPalindrome(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}