using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests79
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, true)]
        [TestCase(new int[] { 1, 1, 2, 1, 1 }, 3, false)]
        [TestCase(new int[] { 1, 1, 2, 1, 5, 4, 7 }, 7, true)]
        [TestCase(new int[] { 1, 1, 2, 1, 5, 4, 7 }, 8, false)]
        [TestCase(new int[] { 5, 5, 5, 6 }, 5, true)]
        [TestCase(new int[0], 5, false)]
        public void TestCheck(int[] b, int h, bool expectedResult)
        {
            bool result = Program79.Check(b, h);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}