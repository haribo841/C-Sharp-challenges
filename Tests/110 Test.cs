using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests110
    {
        [Test]
        [TestCase("Celebration", 5)]
        [TestCase("Palm", 1)]
        [TestCase("Prediction", 4)]
        [TestCase("Suite", 3)]
        [TestCase("Quote", 3)]
        [TestCase("Portrait", 3)]
        [TestCase("Steam", 2)]
        [TestCase("Tape", 2)]
        [TestCase("Nightmare", 3)]
        [TestCase("Convention", 4)]
        public void FixedTest(string str, int expectedResult)
        {
            int result = Program110.CountVowels(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}