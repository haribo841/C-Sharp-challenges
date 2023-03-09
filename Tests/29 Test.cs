using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests29
    {
        [Test]
        [TestCase(10, 100)]
        [TestCase(69, 4761)]
        [TestCase(666, 443556)]
        [TestCase(-21, 441)]
        [TestCase(21, 441)]
        public void FixedTest(int a, int expectedResult)
        {
            int result = Program29.Squared(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}