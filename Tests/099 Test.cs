using Challenges;
using NUnit.Framework;
using System;
namespace Tests
{
    [TestFixture]
    public class Tests99
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, true)]
        [TestCase(new int[] { 5, 5, 3, 4, 5 }, 3, false)]
        [TestCase(new int[] { 5, 4, 5, 6 }, 10, true)]
        [TestCase(new int[] { 1, 2, 1 }, 1, false)]
        [TestCase(new int[] { 3, 3, 3 }, 4, true)]
        [TestCase(new int[] { 4, 4 }, 3, false)]
        [TestCase(new int[] { }, 4, true)]
        public void hurdleJump(int[] x, int y, bool expectedResult)
        {
            bool result = Program99.hurdleJump(x, y);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
