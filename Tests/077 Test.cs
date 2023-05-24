using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests77
    {
        [TestCase(1, 1)]
        [TestCase(67, 2)]
        [TestCase(123, 3)]
        [TestCase(55551, 5)]
        [TestCase(96456431, 8)]
        [TestCase(0, 1)]
        public void FixedTest(int num, int expectedResult)
        {
            int result = Program77.FindDigitAmount(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}