using System;
using Challenges.Edabit;
using Microsoft.Diagnostics.Runtime.Utilities;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests154
    {
        [Test]
        [TestCase(2, 3, 4, 0)]
        [TestCase(7, 3, 7, 2)]
        [TestCase(4, 4, 4, 3)]
        [TestCase(7, 3, 4, 0)]
        [TestCase(3, 3, 6, 2)]
        [TestCase(1, 1, 1, 3)]
        [TestCase(1, 7, 6, 0)]
        [TestCase(7, 7, 7, 3)]
        public void FixedTest(int a, int b, int c, int expectedResult)
        {
            int result = Program154.Equal(a, b, c);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}