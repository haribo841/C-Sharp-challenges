//Given a Rubik's Cube with a side length of n, return the number of individual stickers that are needed to cover the whole cube.
using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests36
    {
        [Test]
        [TestCase(1, 6)]
        [TestCase(2, 24)]
        [TestCase(3, 54)]
        [TestCase(4, 96)]
        [TestCase(5, 150)]
        [TestCase(6, 216)]
        [TestCase(7, 294)]
        [TestCase(8, 384)]
        [TestCase(9, 486)]
        [TestCase(10, 600)]
        [TestCase(11, 726)]
        [TestCase(12, 864)]
        [TestCase(13, 1014)]
        [TestCase(14, 1176)]
        [TestCase(15, 1350)]
        public void FixedTest(int a, int expectedResult)
        {
            // Assert
            int sideLength = a;
            int result = Program36.HowManyStickers(sideLength);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}