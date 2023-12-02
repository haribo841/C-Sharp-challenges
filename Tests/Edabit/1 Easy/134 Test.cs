using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests134
    {
        [Test]
        [TestCase("edabit", "TIBADE")]
        [TestCase("abc", "CBA")]
        [TestCase("hellothere", "EREHTOLLEH")]
        [TestCase("input", "TUPNI")]
        [TestCase("indubitably", "YLBATIBUDNI")]
        public void FixedTest(string str, string expectedResult)
        {
            string result = Program134.ReverseCapitalize(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}