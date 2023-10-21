using System;
using Challenges;
using Microsoft.Diagnostics.Runtime.Utilities;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests152
    {
        [Test]
        [TestCase("the aardvark", "#", "th# ##rdv#rk")]
        [TestCase("minnie mouse", "?", "m?nn?? m??s?")]
        [TestCase("shakespeare", "*", "sh*k*sp**r*")]
        [TestCase("all is fair in love and war", "<", "<ll <s f<<r <n l<v< <nd w<r")]
        public void FixedTest(string str, string ch, string expectedResult)
        {
            string result = Program152.ReplaceVowels(str, ch);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}