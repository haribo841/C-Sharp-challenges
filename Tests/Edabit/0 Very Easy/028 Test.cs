using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests28
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, "15")]
        [TestCase(new int[] { -1, 0, 1 }, "0")]
        [TestCase(new int[] { 0, 4, 8, 12 }, "24")]
        public void FixedTest(int[] arr, string expectedResult)
        {
            string result = Program28.Sumarray(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}