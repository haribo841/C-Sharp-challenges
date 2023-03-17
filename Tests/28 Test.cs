using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests28
    {
        [Test]
        [TestCase(7, false, TestName = "{0} is not divisible by 5")]
        [TestCase(5, true, TestName = "{0} is evenly divisible by 5")]
        [TestCase(15, true, TestName = "{0} is evenly divisible by 5")]
        [TestCase(33, false, TestName = "{0} is not divisible by 5")]
        [TestCase(-18, false, TestName = "{0} is not divisible by 5")]
        [TestCase(999, false, TestName = "{0} is not divisible by 5")]
        [TestCase(2, false, TestName = "{0} is not divisible by 5")]
        public void DivisibleByFive(int x, bool expectedResult)
        {
            bool result = Program28.divisibleByFive(x);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}