using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests144
    {
        [Test]
        [TestCase("#", new int[] { 1, 0 })]
        [TestCase("+++++++", new int[] { 0, 7 })]
        [TestCase("++", new int[] { 0, 2 })]
        [TestCase("#+#+", new int[] { 2, 2 })]
        [TestCase("###+", new int[] { 3, 1 })]
        [TestCase("##+++#", new int[] { 3, 3 })]
        [TestCase("#+++#+#++#", new int[] { 4, 6 })]
        [TestCase("", new int[] { 0, 0 })]
        public void FixedTest(string s, int[] expectedResult)
        {
            int[] result = Program144.HashPlusCount(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}