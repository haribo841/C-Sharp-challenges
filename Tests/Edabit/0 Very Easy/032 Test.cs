using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests32
    {
        [Test]
        [TestCase(100, 200, 200, 100)]
        [TestCase(44, 33, 33, 44)]
        [TestCase(21, 12, 12, 21)]
        [TestCase(10, 20, 20, 10)]
        public void FixedTest(int a, int b, int expected1, int expected2)
        {
            var result = Program32.Swap(a, b);
            Assert.That(result, Is.EqualTo((expected1, expected2)));
        }
    }
}