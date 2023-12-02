using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests130
    {
        [Test]
        [TestCase("loop", true)]
        [TestCase("meeting", true)]
        [TestCase("yummy", true)]
        [TestCase("toodles", true)]
        [TestCase("droop", true)]
        [TestCase("loot", true)]
        [TestCase("orange", false)]
        [TestCase("munchkin", false)]
        [TestCase("forestry", false)]
        [TestCase("raindrops", false)]
        [TestCase("gold", false)]
        [TestCase("paradise", false)]
        [TestCase("chicken", false)]
        public void FixedTest(string word, bool expectedResult)
        {
            bool result = Program130.DoubleLetters(word);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}