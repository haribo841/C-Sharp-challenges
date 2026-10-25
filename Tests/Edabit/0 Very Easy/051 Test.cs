using Challenges.Edabit;
using NUnit.Framework;
using System;
namespace Tests
{
    [TestFixture]
    public class Tests51
    {
        [Test]
        [TestCase("AB", "CD", true)]
        [TestCase("ABC", "DE", false)]
        [TestCase("hello", "edabit", false)]
        [TestCase("meow", "woof", true)]
        [TestCase("jrnvjrnnt", "cvjknfjvmfvnfjn", false)]
        [TestCase("jkvnjrt", "krnf", false)]
        [TestCase("Facebook", "Snapchat", true)]
        public void Comp(string str1, string str2, bool expectedResult)
        {
            bool result = Program51.Comp(str1, str2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}