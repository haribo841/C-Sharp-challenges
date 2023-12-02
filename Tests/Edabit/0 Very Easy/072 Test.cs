using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests72
    {
        [Test]
        [TestCase("abc", "bc", true)]
        [TestCase("abc", "d", false)]
        [TestCase("samurai", "zi", false)]
        [TestCase("feminine", "nine", true)]
        [TestCase("convention", "tio", false)]
        [TestCase("cooperative", "ooper", false)]
        [TestCase("extraterrestrial", "xtraterrestrial", true)]
        [TestCase("access", "ss", true)]
        [TestCase("motorist", "is", false)]
        [TestCase("landowner", "landowner", true)]
        public void FixedTest(string str1, string str2, bool expectedResult)
        {
            bool result = Program72.CheckEnding(str1, str2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}