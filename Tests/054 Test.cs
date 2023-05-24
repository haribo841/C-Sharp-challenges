//Given an array of integers, return the difference between the largest and smallest integers in the array.
using NUnit.Framework;
using System;
using Challenges;
namespace Tests
{
    [TestFixture]
    public class Tests54
    {
        [Test]
        [TestCase(new int[] { -9, -8, 6, -9, 15, 6 }, 24)]
        [TestCase(new int[] { -5, 6, 18, 4, 16, -2 }, 23)]
        [TestCase(new int[] { -2, 20, -9, -9, -2, -7 }, 29)]
        [TestCase(new int[] { 4, -2, 11, -9, 15, 2 }, 24)]
        [TestCase(new int[] { 15, 10, 3, -6, 6, 19 }, 25)]
        [TestCase(new int[] { 1, 7, 18, -1, -2, 9 }, 20)]
        [TestCase(new int[] { 5, 1, -9, 7, -8, -10 }, 17)]
        [TestCase(new int[] { 5, 1, -9, 7, -8, -10 }, 17)]
        [TestCase(new int[] { 4, 17, 12, 2, 10, 2 }, 15)]
        public void Diff(int[] arr, int expectedResult)
        {
            int result = Program54.Diff(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}