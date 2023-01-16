using NUnit.Framework;
using System;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests7
    {
        [Test]
        [TestCase(7, 2, 1, TestName = "{0} divided by 2 should leave a remainder of {1}")]
        [TestCase(3, 4, 3, TestName = "{0} divided by 2 should leave a remainder of {1}")]
        [TestCase(-9, 45, -9, TestName = "{0} divided by 2 should leave a remainder of {1}")]
        [TestCase(5, 5, 0, TestName = "{0} divided by 2 should leave a remainder of {1}")]
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