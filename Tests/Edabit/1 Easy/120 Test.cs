using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests120
    {
        [Test]
        [TestCase("hello", "ell")]
        [TestCase("benefit", "enefi")]
        [TestCase("wordy", "ord")]
        [TestCase("maybe", "ayb")]
        [TestCase("to", "to")]
        [TestCase("a", "a")]
        [TestCase("", "")]
        public void FixedTest(string str, string expectedResult)
        {
            string result = Program120.RemoveFirstLast(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}