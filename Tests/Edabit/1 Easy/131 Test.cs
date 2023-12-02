using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests131
    {
        [Test]
        [TestCase("Hello", 3, "Hellooo")]
        [TestCase("hey", 6, "heyyyyyy")]
        [TestCase("plsssss!1!", 5, "plsssss!1!!!!!")]
        [TestCase("gr", 2, "grr")]
        [TestCase("excuse me what?", 5, "excuse me what?????")]
        [TestCase("123", 5, "1233333")]
        [TestCase("a", 3, "aaa")]
        [TestCase("STOP", 3, "STOPPP")]
        public void FixedTest(string a, int b, string expectedResult)
        {
            string result = Program131.ModifyLast(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}