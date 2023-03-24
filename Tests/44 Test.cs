using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests44
    {
        [Test]
        [TestCase("", true)]
        [TestCase(" ", false)]
        [TestCase("            ", false)]
        [TestCase("38215", false)]
        [TestCase("afjabsdf", false)]
        [TestCase("!?@&", false)]
        public void isEmpty(string s, bool expectedResult)
        {
            bool result = Program44.isEmpty(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}