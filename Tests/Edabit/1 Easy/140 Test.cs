using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests140
    {
        [Test]
        [TestCase("ooxx", true)]
        [TestCase("xooxx", false)]
        [TestCase("ooxXm", true)]
        [TestCase("zpzpzpp", true)]
        [TestCase("zzoo", false)]
        [TestCase("Xo", true)]
        [TestCase("x", false)]
        [TestCase("o", false)]
        [TestCase("xxxoo", false)]
        [TestCase("", true)]
        public static void TestXO(string str, bool expectedResult)
        {
            bool result = Program140.XO(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}