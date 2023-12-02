using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests107
    {
        [TestCase("Donald Trump", "Trump Donald")]
        [TestCase("Rosie O'Donnel", "O'Donnel Rosie")]
        [TestCase("Seymour Butts", "Butts Seymour")]
        [TestCase("Ebony Greene", "Greene Ebony")]
        [TestCase("Ken Kennedy", "Kennedy Ken")]
        [TestCase("Allison Gonzalez", "Gonzalez Allison")]
        [TestCase("Albert Frazier", "Frazier Albert")]
        [TestCase("Eloise Hopkins", "Hopkins Eloise")]
        [TestCase("Donnie Welch", "Welch Donnie")]
        [TestCase("Vernon Thomas", "Thomas Vernon")]
        public void FixedTest(string str, string expectedResult)
        {
            string result = Program107.NameShuffle(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}