using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests17
    {
        [Test]
        [TestCase(true, true, true, TestName = "{0} AND {1} is equal to {2}")]
        [TestCase(true, false, false, TestName = "{0} AND {1} is equal to {2}")]
        [TestCase(false, true, false, TestName = "{0} AND {1} is equal to {2}")]
        [TestCase(false, false, false, TestName = "{0} AND {1} is equal to {2}")]
        public void And(bool x, bool y, bool expectedResult)
        {
            bool result = Program17.And(x, y);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}