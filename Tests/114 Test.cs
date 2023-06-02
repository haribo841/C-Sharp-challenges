using System;
using Challenges;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests114
    {
        [TestCase("HELLO", true)]
        [TestCase("HEllo", false)]
        [TestCase("mArmALadE",  false)]
        [TestCase("marmalade", true)]
        [TestCase("MARMALADE", true)]
        [TestCase("ketchUP", false)]
        [TestCase("pickle", true)]
        [TestCase("MUSTARD", true)]
        public void FixedTest(string str, bool expectedResult)
        {
            bool result = Program114.SameCase(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}