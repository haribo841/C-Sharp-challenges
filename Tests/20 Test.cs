using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests20
    {
        [Test]
        [TestCase("Gerald", "Hello Gerald!")]
        [TestCase("Fatima", "Hello Fatima!")]
        [TestCase("Ed", "Hello Ed!")]
        [TestCase("Tiffany", "Hello Tiffany!")]
        public void FixedTest(string a, string expectedResult)
        {
            string result = Program20.HelloName(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}