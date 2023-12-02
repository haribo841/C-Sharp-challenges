using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    public class Tests13
    {
        [Test]
        [TestCase(2, 7200, TestName = "{0} hours are equal to {1} seconds")]
        [TestCase(10, 36000, TestName = "{0} hours are equal to {1} seconds")]
        [TestCase(24, 86400, TestName = "{0} hours are equal to {1} seconds")]
        [TestCase(36, 129600, TestName = "{0} hours are equal to {1} seconds")]
        public void FixedTest(int hours, int expectedResult)
        {
            int result = Program13.HowManySeconds(hours);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}