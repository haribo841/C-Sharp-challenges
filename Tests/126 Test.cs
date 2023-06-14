using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests126
    {
        [Test]
        [TestCase("increasing", "in... in... increasing?")]
        [TestCase("adventures", "ad... ad... adventures?")]
        [TestCase("enticing", "en... en... enticing?")]
        [TestCase("unacceptable", "un... un... unacceptable?")]
        [TestCase("accountable", "ac... ac... accountable?")]
        [TestCase("incredible", "in... in... incredible?")]
        [TestCase("exquisite", "ex... ex... exquisite?")]
        [TestCase("am", "am... am... am?")]
        [TestCase("enduring", "en... en... enduring?")]
        [TestCase("outstanding", "ou... ou... outstanding?")]
        public void FixedTest(string a, string expectedResult)
        {
            string result = Program126.Stutter(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}