using System;
using Challenges;
using Microsoft.Diagnostics.Runtime.Utilities;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests156
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 }, 5)]
        [TestCase(new int[] { 7, 2, 3, 6, 5, 9, 1, 4, 8 }, 10)]
        [TestCase(new int[] { 7, 2, 3, 9, 4, 5, 6, 8, 10 }, 1)]
        [TestCase(new int[] { 10, 5, 1, 2, 4, 6, 8, 3, 9 }, 7)]
        [TestCase(new int[] { 1, 7, 2, 4, 8, 10, 5, 6, 9 }, 3)]
        public void FixedTest(int[] arr, int expectedResult)
        {
            int result = Program156.MissingNum(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}