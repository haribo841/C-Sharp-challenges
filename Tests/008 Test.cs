using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests8
    {
        [Test]
        [TestCase(5, false)]
        [TestCase(0, true)]
        [TestCase(-5, true)]
        [TestCase(1, false)]
        [TestCase(2, false)]
        [TestCase(1000, false)]
        [TestCase(0.5, false)]
        public void FixedTest(double a, bool expectedResult)
        {
            // Arrange
            double number = a;
            bool result = Program8.LessThanOrEqualToZero(number);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}