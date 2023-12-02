using Challenges.Edabit;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class Test109
    {
        [Test]
        [TestCase(2, 2)]
        [TestCase(6, 720)]
        [TestCase(3, 6)]
        [TestCase(12, 479001600)]
        [TestCase(5, 120)]
        public void FixedTest(int num, int expectedResult)
        {
            int result = Program109.Factorial(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}