using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests122
    {
        [Test]
        [TestCase(17, 8, 24)]
        [TestCase(98, 3, 99)]
        [TestCase(14, 11, 22)]
        [TestCase(11, 8, 16)]
        [TestCase(450, 36, 468)]
        [TestCase(1019, 13, 1027)]
        public void FixedTest(int a, int b, int expectedResult)
        {
            int result = Program122.DivisibleByB(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}