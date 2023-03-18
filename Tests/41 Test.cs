using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests41
    {
        [TestCase(6,  7)]
        [TestCase(3,  3)]
        [TestCase(7,  8)]
        [TestCase(12, 14)]
        [TestCase(213, 248)]
        [TestCase(16, 18)]
        public void FixedTest(int n, int expectedResult)
        {
            int result = Program41.TotalCups(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}