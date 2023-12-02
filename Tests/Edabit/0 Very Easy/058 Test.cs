using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests58
    {
        [Test]
        [TestCase('E', 69)]
        [TestCase('d', 100)]
        [TestCase('a', 97)]
        [TestCase('b', 98)]
        [TestCase('i', 105)]
        [TestCase('t', 116)]
        [TestCase('.', 46)]
        [TestCase(' ', 32)]
        [TestCase('1', 49)]
        public void FixedTest(char a, int expectedResult)
        {
            int result = Program58.CharToASCII(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
