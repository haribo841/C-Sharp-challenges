using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests112
    {
        [Test]
        [TestCase("kkkkk", true)]
        [TestCase("ckkkk", false)]
        [TestCase("kkkkck", false)]
        [TestCase("aabc", false)]
        [TestCase("ccc", true)]
        [TestCase("aabbbb", false)]
        [TestCase("bbbbbb", true)]
        public void FixedTest(string str, bool expectedResult)
        {
            bool result = Program112.IsIdentical(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}