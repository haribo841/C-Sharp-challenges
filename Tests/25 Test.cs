using System;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests25
    {
        [Test]
        [TestCase("Matt", "Hello, Matt!")]
        [TestCase("Helen", "Hello, Helen!")]
        [TestCase("Mubashir", "Hello, my Love!")]

        public void FixedTest(string a, string expectedResult)
        {
            // Arrange
            string name = a;
            string result = Program25.greeting(name);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}