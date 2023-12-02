using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Test62
    {
        [Test]
        [TestCase("dudes", true)]
        [TestCase("flowers", true)]
        [TestCase("checks", true)]
        [TestCase("varies", true)]
        [TestCase("efforts", true)]
        [TestCase("mood", false)]
        [TestCase("whiteboard", false)]
        [TestCase("cow", false)]
        [TestCase("word", false)]
        [TestCase("love", false)]
        public void FixedTest(string word, bool expectedResult)
        {
            bool result = Program62.IsPlural(word);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

