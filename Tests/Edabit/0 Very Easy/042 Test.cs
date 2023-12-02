using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests42
    {
        [Test]
        [TestCase("John", "Doe", "Doe, John")]
        [TestCase("First", "Last", "Last, First")]
        [TestCase("A", "B", "B, A")]
        [TestCase(",", ",", ",, ,")]
        public void FixedTest(string firstName, string lastName, string expectedResult)
        {
            string result = Program42.ConcatName(firstName, lastName);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}