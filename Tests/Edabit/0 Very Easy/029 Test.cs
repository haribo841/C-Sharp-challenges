using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests29
    {
        [Test]
        [TestCase("Matt", "Hello, Matt!")]
        [TestCase("Helen", "Hello, Helen!")]
        [TestCase("Mubashir", "Hello, my Love!")]
        public void FixedTest(string a, string expectedResult)
        {
            string result = Program29.Greeting(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}