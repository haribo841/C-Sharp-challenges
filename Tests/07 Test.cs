using NUnit.Framework;
using System;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests7
    {
        [Test]
        [TestCase(7, 2, 1, TestName = "7 divided by 2 should leave a remainder of 1")]
        [TestCase(3, 4, 3, TestName = "3 divided by 4 should leave a remainder of 3")]
        [TestCase(-9, 45, -9, TestName = "-9 divided by 45 should leave a remainder of -9")]
        [TestCase(5, 5, 0, TestName = "5 divided by 5 should leave a remainder of 0")]
        public void Remainder(int x, int y, int expectedResult)
        {
            // Arrange
            int dividend = x;
            int divider = y;
            int result = Program7.Remainder(dividend, divider);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}