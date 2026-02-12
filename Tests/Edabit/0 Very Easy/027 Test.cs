using System;
using System.Drawing;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests27
    {
        [Test]
        [TestCase(3, 7, 7)]
        [TestCase(-1, 0, 0)]
        [TestCase(1000, 400, 1000)]
        [TestCase(-3, -9, -3)]
        [TestCase(88, 90, 90)]

        public void FixedTest(int n1, int n2, int expectedResult)
        {
            int result = Program27.Maxnum(n1, n2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}