using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests10
    {
        [Test]
        [TestCase(2, 2, true, TestName = "{0} is equal to {1}")]
        [TestCase(88, 88, true, TestName = "{0} is equal to {1}")]
        [TestCase(36, 35, false, TestName = "{0} is not equal to {1}")]
        [TestCase(1, 1, true, TestName = "{0} is equal to {1}")]
        [TestCase(5, 6, false, TestName = "{0} is not equal to {1}")]
        public void FixedTest(int num1, int num2, bool expectedResult)
        {
            bool result = Program10.IsEqual(num1, num2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}