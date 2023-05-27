using Challenges;
using NUnit.Framework;
using System;
namespace Tests
{
    [TestFixture]
    public class Test106
    {
        [Test]
        [TestCase("abcde", "bcdef", 5)]
        [TestCase("abcde", "abcde", 0)]
        [TestCase("strong", "strung", 1)]
        public void FixedTest(string str1, string str2, int expectedResult)
        {
            int result = Program106.HammingDistance(str1, str2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
