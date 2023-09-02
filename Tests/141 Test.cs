using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests141
    {
        [Test]
        [TestCase("hello", ExpectedResult = "ehllo")]
        [TestCase("edabit", ExpectedResult = "abdeit")]
        [TestCase("hacker", ExpectedResult = "acehkr")]
        [TestCase("geek", ExpectedResult = "eegk")]
        [TestCase("javascript", ExpectedResult = "aacijprstv")]
        [TestCase("credibility", ExpectedResult = "bcdeiiilrty")]
        [TestCase("apostrophe", ExpectedResult = "aehoopprst")]
        [TestCase("determination", ExpectedResult = "adeeiimnnortt")]
        [TestCase("win", ExpectedResult = "inw")]
        [TestCase("synthesis", ExpectedResult = "ehinsssty")]
        public static string TestAlphabetSoup(string str)
        {
            string result = Program141.AlphabetSoup(str);
            //Assert.That(result, Is.EqualTo(TestContext.CurrentContext.Result));
            return result;
        }
    }
}