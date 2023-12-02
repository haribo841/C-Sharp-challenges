using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests53
    {
        [Test]
        [TestCase("apple", 5)]
        [TestCase("make", 4)]
        [TestCase("a", 1)]
        [TestCase("", 0)]
        public void FixedTest(string a, int expectedResult)
        {
            // Arrange
            string word = a;
            int result = Program53.Length(word);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}