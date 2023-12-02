using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Test63
    {
        [Test]
        [TestCase(12, 12, "added")]
        [TestCase(100, 76, "subtracted")]
        [TestCase(6, 4, "multiplied")]
        [TestCase(528, 22, "divided")]
        [TestCase(10, 12, "none")]
        public void FixedTest(int num1, int num2, string expectedResult)
        {
            string result = Program63.Operation(num1, num2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

