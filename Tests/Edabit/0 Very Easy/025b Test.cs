using System;
using System.Xml.Linq;
using Challenges.Edabit;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests25b
    {
        [Test]
        [TestCase("Matt", "Hello, Matt!")]
        [TestCase("Helen", "Hello, Helen!")]
        [TestCase("Mubashir", "Hello, my Love!")]

        public void FixedTest(string a, string expectedResult)
        {
            // Arrange
            string name = a;
            string result = Program25b.Greeting(name);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}