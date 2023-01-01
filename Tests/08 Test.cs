using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests8
    {
        [Test]
        [TestCase(5, false, TestName = "5 is not eual or less than zero")]
        [TestCase(0, true, TestName = "0 is eual or less than zero")]
        [TestCase(-5, true, TestName = "-5 is eual or less than zero")]
        [TestCase(1, false, TestName = "1 is not eual or less than zero")]
        [TestCase(2, false, TestName = "2 is not eual or less than zero")]
        [TestCase(1000, false, TestName = "1000 is not eual or less than zero")]
        [TestCase(0.5, false, TestName = "0.5 is not eual or less than zero")]
        public void FixedTest(double a, bool expectedResult)
        {
            // Arrange
            double number = a;
            bool result = Program8.LessThanOrEqualToZero(number);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}