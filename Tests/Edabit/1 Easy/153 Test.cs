using System;
using Challenges.Edabit;
using Microsoft.Diagnostics.Runtime.Utilities;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests153
    {
        [Test]
        [TestCase("apple", "banana", "azure", true)]
        [TestCase("bookcase", "zebra", "squid", true)]
        [TestCase("shrapnel", "tapenade", "tally", true)]
        [TestCase("monk", "monument", "monkey", true)]
        [TestCase("oath", "ostrich", "osteoporosis", true)]
        [TestCase("ostracize", "ostrich", "open", false)]
        [TestCase("bookend", "boolean", "boost", false)]
        [TestCase("tamer", "tanner", "timid", false)]
        [TestCase("rhino", "sorcerer", "quote", false)]
        [TestCase("body", "lung", "ace", false)]
        public void FixedTest(string first, string last, string word, bool expectedResult)
        {
            bool result = Program153.IsBetween(first, last, word);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}