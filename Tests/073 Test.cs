using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests73
    {
        [Test]
        [TestCase(new int[] { 1, 5, 3 }, 5, 1)]
        [TestCase(new int[] { 9, 8, 3 }, 3, 2)]
        [TestCase(new int[] { 1, 2, 3 }, 4, -1)]
        [TestCase(new int[] { 1, 5, 3, 10, 17, 20, -6 }, 20, 5)]
        public void FixedTest(int[] a, int b, int expectedResult)
        {
            int result = Program73.Search(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}