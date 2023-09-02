using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Test139
    {
        [Test]
        public void GenericTests()
        {
            string[] haystack_1 = new string[] { "Ryan", "Kieran", "Jason", "Matt" };
            string[] haystack_2 = new string[] { "Tomato", "Potato", "Pair" };
            string[] haystack_3 = new string[] { "Kangaroo", "Bear", "Fox" };
            string[] haystack_4 = new string[] { "Red", "Blue", "Green", "Pink" };
            string[] haystack_5 = new string[] { "is", "up", "two", "elephant" };
            string[] haystack_6 = new string[] { "jazz", "quiz", "jump" };
            string[] haystack_7 = new string[] { "" };
            string[] haystack_8 = new string[] { "Broccoli", "Carrot", "Spinach" };
            string[] haystack_9 = Array.Empty<string>();

            Assert.AreEqual(new string[] { "Ryan", "Matt" }, Program139.IsFourLetters(haystack_1));
            Assert.AreEqual(new string[] { "Pair" }, Program139.IsFourLetters(haystack_2));
            Assert.AreEqual(new string[] { "Bear" }, Program139.IsFourLetters(haystack_3));
            Assert.AreEqual(new string[] { "Blue", "Pink" }, Program139.IsFourLetters(haystack_4));
            Assert.AreEqual(new string[] { }, Program139.IsFourLetters(haystack_5));
            Assert.AreEqual(new string[] { "jazz", "quiz", "jump" }, Program139.IsFourLetters(haystack_6));
            Assert.AreEqual(new string[] { }, Program139.IsFourLetters(haystack_7));
            Assert.AreEqual(new string[] { }, Program139.IsFourLetters(haystack_8));
            Assert.AreEqual(new string[] { }, Program139.IsFourLetters(haystack_9));
        }
    }
}