using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests37
    {
        [Test]
        [TestCase(1, 0)]
        [TestCase(0, 1)]
        public void FixedTest(int ib, int expectedResult)
        {
            int result = Program37.FlipIntBool(ib);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}