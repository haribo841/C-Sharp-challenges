using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests136
    {
        [Test]
        [TestCase("mice", 5, "mmmmmiiiiiccccceeeee")]
        [TestCase("hello", 3, "hhheeellllllooo")]
        [TestCase("stop", 1, "stop")]
        [TestCase("tomato", 2, "ttoommaattoo")]
        public static void TestFormatPhoneNumber(string str, int num, string expectedResult)
        {
            string result = Program136.Repeat(str, num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}