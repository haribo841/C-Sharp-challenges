using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests117
    {
        [Test]
        [TestCase(3, "Burrrp")]
        [TestCase(5, "Burrrrrp")]
        [TestCase(9, "Burrrrrrrrrp")]
        [TestCase(10, "Burrrrrrrrrrp")]
        [TestCase(13, "Burrrrrrrrrrrrrp")]
        [TestCase(18, "Burrrrrrrrrrrrrrrrrrp")]
        [TestCase(1, "Burp")]
        public void FixedTest(int a, string expectedResult)
        {
            string result = Program117.LongBurp(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}