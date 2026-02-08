using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests31
    {
        [Test]
        [TestCase("mubashir1", "mubashir")]
        [TestCase("12ma23tt", "matt")]
        [TestCase("e1d2a3b4i5t6", "edabit")]
        [TestCase("pakistan007", "pakistan")]
        [TestCase("ai4653rf53or4235ce", "airforce")]
        public void FixedTest(string a, string expectedResult)
        {
            string result = Program31.RemoveNumbers(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}