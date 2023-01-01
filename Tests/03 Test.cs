using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests3
    {
        [Test]
        [TestCase(2, 3, TestName = "2 incremented by one should be 3")]
        [TestCase(-9, -8, TestName = "-9 incremented by one should be -8")]
        [TestCase(0, 1, TestName = "0 incremented by one should be 1")]
        [TestCase(100, 101, TestName = "100 incremented by one should be 101")]
        [TestCase(999, 1000, TestName = "999 incremented by one should be 1000")]
        [TestCase(73, 74, TestName = "73 incremented by one should be 74")]
        public void FixedTest(int num, int expectedResult)
        {
            int result = Program3.Addition(num);
            Assert.That(result, Is.EqualTo(expectedResult));// Assert
        }
    }
}