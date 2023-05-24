using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests43
    {
        [Test]
        [TestCase(5, 3, 15)]
        [TestCase(8, 5, 40)]
        [TestCase(5, 4, 20)]
        [TestCase(2, 3, 6)]
        [TestCase(10000, 10000, 100000000)]
        [TestCase(-2, -5, -1)]
        [TestCase(0, 3, -1)]
        [TestCase(5, -3, -1)]
        [TestCase(0, 1, -1)]
        [TestCase(-1, 0, -1)]
        public void Area(int h, int w, int expectedResult)
        {
            int result = Program43.Area(h, w);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}