using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests59
    {
        [Test]
        [TestCase(12, 2)]
        [TestCase(6000, 4)]
        [TestCase(314, 3)]
        public void FixedTest(int n, int expectedResult)
        {
            int result = Program59.Length(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
