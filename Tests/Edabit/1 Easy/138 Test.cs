using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests138
    {
        [Test]
        [TestCase(new int[] { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 }, 2.55)]
        [TestCase(new int[] { 324, 543, 654, 9876 }, 2849.25)]
        [TestCase(new int[] { 0, 0, 0, 0 }, 0.0)]
        [TestCase(new int[] { 30, 40, 20, 100, 30 }, 44.0)]
        [TestCase(new int[] { 1, 1, 1, 0 }, 0.75)]
        [TestCase(new int[] { 1, 1, 0, 1, 2, 1, 1, 1, 0, 0 }, 0.8)]
        [TestCase(new int[] { 10000 }, 10000.0)]
        public static void TestMean(int[] arr, double expectedResult)
        {
            double result = Program138.Mean(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}