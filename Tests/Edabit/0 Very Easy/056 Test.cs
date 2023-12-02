using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests56
    {
        [Test]
        [TestCase("Foo", false)]
        [TestCase("Foo bar", true)]
        [TestCase("Foo ", true)]
        [TestCase(" Foo", true)]
        [TestCase(" ", true)]
        [TestCase("", false)]
        [TestCase(",./;'[]-=", false)]
        public void FixedTest(string str, bool expectedResult)
        {
            bool result = Program56.HasSpaces(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}