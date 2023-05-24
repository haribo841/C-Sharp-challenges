using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests100
    {
        [Test]
        [TestCase('a', "edabit", 1)]
        [TestCase('b', "big fat bubble", 4)]
        [TestCase('c', "Chamber of secrets", 1)]
        [TestCase('f', "frank and his friends have offered five foxes for sale", 7)]
        [TestCase('x', "edabit", 0)]
        [TestCase('a', "Adam and Eve bit the apple and found a snake", 6)]
        [TestCase('s', "sssssssssssssssssssssssss", 25)]
        [TestCase('7', "10795426697", 2)]
        public void CharCount(char myChar, string str, int expectedResult)
        {
            int result = Program100.CharCount(myChar, str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
