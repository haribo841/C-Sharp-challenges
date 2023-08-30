using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests123
    {
        [TestCase(1, 1)]
        [TestCase(5, 15)]
        [TestCase(7, 28)]
        [TestCase(10, 55)]
        [TestCase(12, 78)]
        [TestCase(15, 120)]
        [TestCase(20, 210)]
        [TestCase(100, 5050)]
        public void TestSum(int n, int expectedResult)
        {
            int result = Program123.Sum(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}