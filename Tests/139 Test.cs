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
            Assert.Multiple(() =>
            {
                Assert.That(Program139.IsFourLetters(haystack_1), Is.EqualTo(new string[] { "Ryan", "Matt" }));
                Assert.That(Program139.IsFourLetters(haystack_2), Is.EqualTo(new string[] { "Pair" }));
                Assert.That(Program139.IsFourLetters(haystack_3), Is.EqualTo(new string[] { "Bear" }));
                Assert.That(Program139.IsFourLetters(haystack_4), Is.EqualTo(new string[] { "Blue", "Pink" }));
                Assert.That(Program139.IsFourLetters(haystack_5), Is.EqualTo(new string[] { }));
                Assert.That(Program139.IsFourLetters(haystack_6), Is.EqualTo(new string[] { "jazz", "quiz", "jump" }));
                Assert.That(Program139.IsFourLetters(haystack_7), Is.EqualTo(new string[] { }));
                Assert.That(Program139.IsFourLetters(haystack_8), Is.EqualTo(new string[] { }));
                Assert.That(Program139.IsFourLetters(haystack_9), Is.EqualTo(new string[] { }));
            });
        }
    }
}