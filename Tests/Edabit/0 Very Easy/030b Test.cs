using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests30b
    {
        [Test]
        [TestCase(1, 0)]
        [TestCase(0, 1)]
        public void FixedTest(int ib, int expectedResult)
        {
            int result = Program30b.FlipIntBool(ib);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}