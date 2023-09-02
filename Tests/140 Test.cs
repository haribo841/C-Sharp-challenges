using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests140
    {
        [Test]
        [TestCase("ooxx", ExpectedResult = true)]
        [TestCase("xooxx", ExpectedResult = false)]
        [TestCase("ooxXm", ExpectedResult = true)]
        [TestCase("zpzpzpp", ExpectedResult = true)]
        [TestCase("zzoo", ExpectedResult = false)]
        [TestCase("Xo", ExpectedResult = true)]
        [TestCase("x", ExpectedResult = false)]
        [TestCase("o", ExpectedResult = false)]
        [TestCase("xxxoo", ExpectedResult = false)]
        [TestCase("", ExpectedResult = true)]
        public static bool TestXO(string str)
        {
            return Program140.XO(str);
        }
    }
}