using Challenges.Edabit;
using NUnit.Framework;
using System;
namespace Tests
{
    [TestFixture]
    public class Tests98
    {
        [Test]
        [TestCase("buf-fet", 2)]
        [TestCase("beau-ti-ful", 3)]
        [TestCase("mon-u-men-tal", 4)]
        [TestCase("on-o-mat-o-poe-ia", 6)]
        [TestCase("o-ver-ly", 3)]
        [TestCase("pas-try", 2)]
        [TestCase("flu-id", 2)]
        [TestCase("syl-la-ble", 3)]
        public void FixedTest(string word, int expectedResult)
        {
            int result = Program98.NumberSyllables(word);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
