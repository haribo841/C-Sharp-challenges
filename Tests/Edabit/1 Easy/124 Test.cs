using System;
using Challenges.Edabit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests124
    {
        [Test]
        [TestCase("soccer", 2, "soccersoccer")]
        [TestCase("ab", 3, "ababab")]
        [TestCase("this", 1, "this")]
        [TestCase("ciao", 4, "ciaociaociaociao")]
        [TestCase("charon", 5, "charoncharoncharoncharoncharon")]
        [TestCase("sa", 10, "sasasasasasasasasasa")]
        public void FixedTest(string a, int b, string expectedResult)
        {
            string result = Program124.Repetition(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}