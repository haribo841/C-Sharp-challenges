using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests3
    {
        [Test]
        [TestCase(2, 3, TestName = "{0} incremented by one should be {1}")]
        [TestCase(-9, -8, TestName = "{0} incremented by one should be {1}")]
        [TestCase(0, 1, TestName = "{0} incremented by one should be {1}")]
        [TestCase(100, 101, TestName = "{0} incremented by one should be {1}")]
        [TestCase(999, 1000, TestName = "{0} incremented by one should be {1}")]
        [TestCase(73, 74, TestName = "{0} incremented by one should be {1}")]
        public void FixedTest(int num, int expectedResult)
        {
            int result = Program3.Addition(num);
            Assert.That(result, Is.EqualTo(expectedResult));// Assert
        }
    }
}