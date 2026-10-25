using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests50
    {
        [Test]
        [TestCase("", true)]
        [TestCase(" ", false)]
        [TestCase("            ", false)]
        [TestCase("38215", false)]
        [TestCase("afjabsdf", false)]
        [TestCase("!?@&", false)]
        public void IsEmpty(string s, bool expectedResult)
        {
            bool result = Program50.IsEmpty(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}