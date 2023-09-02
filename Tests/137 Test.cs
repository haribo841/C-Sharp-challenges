using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests137
    {
        [Test]
        [TestCase(new int[] { 3, 5, 9 }, false)]
        [TestCase(new int[] { 1, 1, 1, 1 }, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, true)]
        [TestCase(new int[] { 5, 2, 4 }, false)]
        [TestCase(new int[] { 11, 22 }, false)]
        [TestCase(new int[] { 4, 1, 7, 9, 2, 5, 7, 2, 4 }, false)]
        public static void TestIsAvgWhole(int[] arr, bool expectedResult)
        {
            bool result = Program137.IsAvgWhole(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}