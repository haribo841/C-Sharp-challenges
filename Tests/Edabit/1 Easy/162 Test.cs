using System;
using Challenges.Edabit;
using Microsoft.Diagnostics.Runtime.Utilities;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests162
    {
        [Test]
        [TestCase(new int[] { 3, 4 }, 5)]
        [TestCase(new int[] { 0, 0, -10 }, 10)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 2, 3, 6, 1, 8 }, 10.677078252031311)]
        [TestCase(new int[] { 9, -9, 3 }, 13.076696830622021)]
        [TestCase(new int[] { -24, 94, 4, 0, 10 }, 97.61147473529944)]
        public void FixedTest(int[] a, double expectedResult)
        {
            double result = Program162.Magnitude(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}