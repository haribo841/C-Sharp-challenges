using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Test139
    {
        [Test]
        [TestCase(new string[] { "Ryan", "Kieran", "Jason", "Matt" }, new string[] { "Ryan", "Matt" })]
        [TestCase(new string[] { "Tomato", "Potato", "Pair" }, new string[] { "Pair" })]
        [TestCase(new string[] { "Kangaroo", "Bear", "Fox" }, new string[] { "Bear" })]
        [TestCase(new string[] { "Red", "Blue", "Green", "Pink" }, new string[] { "Blue", "Pink" })]
        [TestCase(new string[] { "is", "up", "two", "elephant" }, new string[] { })]
        [TestCase(new string[] { "jazz", "quiz", "jump" }, new string[] { "jazz", "quiz", "jump" })]
        [TestCase(new string[] { "" }, new string[] { })]
        [TestCase(new string[] { "Broccoli", "Carrot", "Spinach" }, new string[] { })]
        public static void TestIsFourLetters(string[] arr, string[] expectedResult)
        {
            string[] result = Program139.IsFourLetters(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}