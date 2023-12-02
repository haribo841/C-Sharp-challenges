using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests31
    {
        [Test]
        [TestCase(98, 7, true)]
        [TestCase(87, 49, false)]
        [TestCase(34, 14, false)]
        [TestCase(78, 6, true)]
        [TestCase(30, 4, false)]
        [TestCase(87, 73, false)]
        [TestCase(74, 7, false)]
        [TestCase(87, 29, true)]
        [TestCase(48, 24, true)]
        [TestCase(99, 20, false)]
        [TestCase(98, 49, true)]
        [TestCase(100, 6, false)]
        [TestCase(64, 4, true)]
        [TestCase(70, 35, true)]
        [TestCase(38, 38, true)]
        [TestCase(29, 3, false)]
        [TestCase(20, 8, false)]
        [TestCase(66, 50, false)]
        [TestCase(95, 1, true)]
        [TestCase(58, 2, true)]

        public void FixedTest(int a, int b, bool expectedResult)
        {
            // Arrange
            int dividend = a;
            int divider = b;
            bool result = Program31.DividesEvenly(dividend, divider);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}