using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests104
    {
        [Test]
        [TestCase(5, 5, 3125)]
        [TestCase(3, 3, 27)]
        [TestCase(10, 10, 10000000000)]
        public void CalculateExponent(long number, long exponent, long expectedResult)
        {
            long result = Program104.CalculateExponent(number, exponent);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
