using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests103
    {
        [Test]
        [TestCase(new int[] { 2, -1, -3, 4, 8 }, 18)]
        [TestCase(new int[] { -1 }, 1)]
        [TestCase(new int[] { -1, -3, -5, -4, -10, 0 }, 23)]
        [TestCase(new int[] { 8, 9, 10, 32, 101, -10 }, 170)]
        [TestCase(new int[] { 500 }, 500)]
        public void FixedTest(int[] arr, int expectedResult)
        {
            int result = Program103.GetAbsSum(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}