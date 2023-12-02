using System;
using Challenges.Edabit;
using Microsoft.Diagnostics.Runtime.Utilities;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests155
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, 2)]
        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 8, 3)]
        [TestCase(new int[] { 1, 3, 5, 7, 9 }, 11, -1)]
        [TestCase(new int[] { 1, 5, 7, 11, 25, 100, 200, 350 }, 5, 1)]
        public void FixedTest(int[] a, int b, int expectedResult)
        {
            int result = Program155.Search(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}