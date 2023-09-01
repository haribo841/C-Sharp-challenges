using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests137
    {
        [Test]
        [TestCase(new int[] { 3, 5, 9 }, ExpectedResult = false)]
        [TestCase(new int[] { 1, 1, 1, 1 }, ExpectedResult = true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = true)]
        [TestCase(new int[] { 5, 2, 4 }, ExpectedResult = false)]
        [TestCase(new int[] { 11, 22 }, ExpectedResult = false)]
        [TestCase(new int[] { 4, 1, 7, 9, 2, 5, 7, 2, 4 }, ExpectedResult = false)]
        public static bool TestIsAvgWhole(int[] arr)
        {
            return Program137.IsAvgWhole(arr);
        }
    }
}