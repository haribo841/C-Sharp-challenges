using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests59
    {
        [Test]
        [TestCase("apple", 5)]
        [TestCase("make", 4)]
        [TestCase("a", 1)]
        [TestCase("", 0)]
        [TestCase("C#", 2)]
        [TestCase("ąęć", 3)]
        public void FixedTest(string a, int expectedResult)
        {
            int result = Program59.Length(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
