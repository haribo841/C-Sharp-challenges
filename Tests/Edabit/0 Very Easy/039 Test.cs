using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests39
    {
        [Test]
        [TestCase(1, 1, 60)]
        [TestCase(10, 1, 600)]
        [TestCase(10, 25, 15000)]
        [TestCase(500, 60, 1800000)]
        [TestCase(0, 60, 0)]
        [TestCase(99, 1, 5940)]
        [TestCase(419, 70, 1759800)]
        [TestCase(52, 33, 102960)]
        public void FixedTest(int a, int b, int expectedResult)
        {
            int result = Program39.Frames(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}