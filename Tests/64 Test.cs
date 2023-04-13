using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests64
    {
        [Test]
        [TestCase("37", 37)]
        [TestCase("113", 113)]
        [TestCase("5", 5)]
        [TestCase("5231", 5231)]
        public void FixedTest(string a, int expectedResult)
        {
            int result = Program64.toInt(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        [TestCase(37, "37")]
        [TestCase(113, "113")]
        [TestCase(5, "5")]
        [TestCase(5231, "5231")]
        public void FixedTest(int a, string expectedResult)
        {
            string result = Program64.toStr(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}