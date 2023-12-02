using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests147
    {
        [Test]
        [TestCase(1, 0, -1, 2)]
        [TestCase(1, 0, 0, 1)]
        [TestCase(1, 0, 1, 0)]
        [TestCase(200, 420, 800, 0)]
        [TestCase(200, 420, -800, 2)]
        [TestCase(1000, 1000, 0, 2)]
        [TestCase(10000, 400, 4, 1)]
        public void FixedTest(int a, int b, int c, int expectedResult)
        {
            int result = Program147.Solutions(a, b, c);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}