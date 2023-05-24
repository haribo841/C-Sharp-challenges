using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests81
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 5, 6, 7 }, new int[] { 7, 6, 5 })]
        [TestCase(new int[] { 9, 9, 2, 3, 4 }, new int[] { 4, 3, 2, 9, 9 })]
        [TestCase(new int[] { 3, 3 }, new[] { 3, 3 })]
        [TestCase(new int[] { -1, -1, -1 }, new int[] { -1, -1, -1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void Reverse(int[] arr, int[] expectedResult)
        {
            int[] result = Program81.Reverse(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}