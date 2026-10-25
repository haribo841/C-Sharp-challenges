using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests168
    {
        [Test]
        [TestCase("6", 6)]
        [TestCase("2", 2)]
        [TestCase("10", 10)]
        [TestCase("666", 666)]
        public void FixedTest(string num, int expectedResult)
        {
            int result = Program168.StringInt(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
