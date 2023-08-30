using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests133
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 2, 4, 6, 8 })]
        [TestCase(new int[] { 43, 65, 23, 89, 53, 9, 6 }, new int[] { 6 })]
        [TestCase(new int[] { 718, 991, 449, 644, 380, 440 }, new int[] { 718, 644, 380, 440 })]
        [TestCase(new int[] { 148, 6, 16, 85 }, new int[] { 148, 6, 16 })]
        [TestCase(new int[] { 9, 49, 23 }, new int[0])]
        [TestCase(new int[] { 34, 43, 32, 49, 40 }, new int[] { 34, 32, 40 })]
        [TestCase(new int[] { 1232, 1990, 1284, 1391, 1958 }, new int[] { 1232, 1990, 1284, 1958 })]
        [TestCase(new int[] { 2766, 2651, 2373, 2916, 2397, 2539 }, new int[] { 2766, 2916 })]
        [TestCase(new int[] { 53, 65, 52, 62, 59 }, new int[] { 52, 62 })]
        [TestCase(new int[]  { 393, 156, 14, 166, 129, 246 }, new int[] { 156, 14, 166, 246 })]
        public void FixedTest(int[] arr, int[] expectedResult)
        {
            int[] result = Program133.NoOdds(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}