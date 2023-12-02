using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests67
    {
        [Test]
        [TestCase(new int[] { 4, 5, 1, 3 }, 5)]
        [TestCase(new int[] { 13, 27, 18, 26 }, 27)]
        [TestCase(new int[] { 32, 35, 37, 39 }, 39)]
        [TestCase(new int[] { 1000, 1001, 857, 1 }, 1001)]
        [TestCase(new int[] { 27364, 837363, 736736, 73635 }, 837363)]
        [TestCase(new int[] { 30, 2, 40, 3 }, 40)]
        [TestCase(new int[] { 0, 1, 0, 0, 1 }, 1)]
        public void FixedTest(int[] arr, object expectedResult)
        {
            object result = Program67.FindLargestNum(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}