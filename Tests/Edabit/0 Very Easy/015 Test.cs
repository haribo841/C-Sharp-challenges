using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests15
    {
        [Test]
        [TestCase(4, 8, false, TestName = "{0} is not equal to {1}")]
        [TestCase(111, 111, true, TestName = "{0} is equal to {1}")]
        [TestCase(2, 5, false, TestName = "{0} is not equal to {1}")]
        [TestCase(0, 6, false, TestName = "{0} is not equal to {1}")]
        [TestCase(10, 10, true, TestName = "{0} is equal to {1}")]
        public void FixedTest(int a, int b, bool expectedResult)
        {
            bool result = Program15.IsSameNum(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}