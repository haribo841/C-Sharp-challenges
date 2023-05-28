using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests108
    {
        [Test]
        [TestCase("21", "44", "21")]
        [TestCase("153", "367", "153")]
        [TestCase("1500", "16", "16")]
        [TestCase("100", "23", "23")]
        [TestCase("1500", "1", "1")]
        [TestCase("5", "5", "5")]
        public void SmallerNum(string n1, string n2, string expectedResult)
        {
            string result = Program108.SmallerNum(n1, n2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}