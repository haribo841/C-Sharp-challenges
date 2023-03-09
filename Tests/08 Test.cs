using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests8
    {
        [Test]
        [TestCase(5, false, TestName = "{0} is not eual or less than zero")]
        [TestCase(0, true, TestName = "{0} is eual or less than zero")]
        [TestCase(-5, true, TestName = "{0} is eual or less than zero")]
        [TestCase(1, false, TestName = "{0} is not eual or less than zero")]
        [TestCase(2, false, TestName = "{0} is not eual or less than zero")]
        [TestCase(1000, false, TestName = "{0} not is eual or less than zero")]
        [TestCase(0.5, false, TestName = "{0} not is eual or less than zero")]
        public void FixedTest(double a, bool expectedResult)
        {
            // Arrange
            double number = a;
            bool result = Program8.LessThanOrEqualToZero(number);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}