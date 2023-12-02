using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests70
    {
        [Test]
        [TestCase("hello", "hELLo", true)]
        [TestCase("hey", "hey", true)]
        [TestCase("venom", "VENOM", true)]
        [TestCase("maGIciAN", "magician", true)]
        [TestCase("stupIFy", "stupifY", true)]
        [TestCase("bald", "blad", false)]
        [TestCase("motive", "emotive", false)]
        [TestCase("mask", "mAskinG", false)]
        [TestCase("skim", "skimp", false)]
        [TestCase("EXCEl", "exceLs", false)]
        public void FixedTest(string s1, string s2, bool expectedResult)
        {
            bool result = Program70.Match(s1, s2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}