using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests11
    {
        [Test]
        [TestCase("a", "something a")]
        [TestCase("is cooking", "something is cooking")]
        [TestCase(" is cooking", "something  is cooking")]
        public void FixedTest(string a, string expectedResult)
        {
            string result = Program11.GiveMeSomething(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}