using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests146
    {
        [Test]
        [TestCase(1, 1, 1, true)]
        [TestCase(12, 15, 10, true)]
        [TestCase(15228, 9209, 72162, true)]
        [TestCase(15, 1, 1, false)]
        [TestCase(123, 15, 10, false)]
        [TestCase(5213, 99219, 6165, false)]
        [TestCase(1523, 513, 512, false)]
        [TestCase(-15, 1, 1, false)]
        [TestCase(123, -15, 10, false)]
        [TestCase(-12, 15, -10, true)]
        [TestCase(15228, -9209, -72162, true)]
        public void FixedTest(int a, int b, int c, bool expectedResult)
        {
            bool result = Program146.LastDig(a, b, c);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}