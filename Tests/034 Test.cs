using Challenges;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests34
    {
        [Test]
        [TestCase(1, false)]
        [TestCase(100, true)]
        [TestCase(1000, true)]
        [TestCase(111000, true)]
        [TestCase(-1, false)]
        [TestCase(0, true)]
        [TestCase(-100, true)]
        public static void DivisibleTest(int number, bool expectedResult)
        {
            bool result = Program34.Divisible(number);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}