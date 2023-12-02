using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests141
    {
        [Test]
        [TestCase("hello", "ehllo")]
        [TestCase("edabit", "abdeit")]
        [TestCase("hacker", "acehkr")]
        [TestCase("geek", "eegk")]
        [TestCase("javascript", "aacijprstv")]
        [TestCase("credibility", "bcdeiiilrty")]
        [TestCase("apostrophe", "aehoopprst")]
        [TestCase("determination", "adeeiimnnortt")]
        [TestCase("win", "inw")]
        [TestCase("synthesis", "ehinsssty")]
        public static void TestAlphabetSoup(string str, string expectedResult)
        {
            string result = Program141.AlphabetSoup(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}