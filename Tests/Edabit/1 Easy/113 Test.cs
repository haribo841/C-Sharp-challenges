using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests113
    {
        [Test]
        [TestCase("javascript is cool", "j4v45cr1pt 15 c00l")]
        [TestCase("become a coder", "b3c0m3 4 c0d3r")]
        [TestCase("hi there", "h1 th3r3")]
        [TestCase("programming is fun", "pr0gr4mm1ng 15 fun")]
        [TestCase("keep on practicing", "k33p 0n pr4ct1c1ng")]
        public void FixedTest(string str, string expectedResult)
        {
            string result = Program113.HackerSpeak(str);
            Assert.That(result, Is.EqualTo(expectedResult));// Assert
        }
    }
}