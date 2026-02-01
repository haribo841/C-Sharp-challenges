using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests23
    {
        [Test]
        [TestCase(true, "sad days")]
        [TestCase(false, "it's a good day")]
        public void FixedTest(bool buggy_code, string expectedResult)
        {
            string result = Program23.Has_bugs(buggy_code);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}