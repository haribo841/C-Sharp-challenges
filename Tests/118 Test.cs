using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests118
    {
        [Test]
        [TestCase(1, "circle")]
        [TestCase(2, "semi-circle")]
        [TestCase(3, "triangle")]
        [TestCase(4, "square")]
        [TestCase(5, "pentagon")]
        [TestCase(6, "hexagon")]
        [TestCase(7, "heptagon")]
        [TestCase(8, "octagon")]
        [TestCase(9, "nonagon")]
        [TestCase(10, "decagon")]
        public void FixedTest(int n, string expectedResult)
        {
            string result = Program118.NSidedShape(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}