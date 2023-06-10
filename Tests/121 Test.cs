using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests121
    {
        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(98, "98")]
        [TestCase(10, "Buzz")]
        [TestCase(4, "4")]
        public void FixedTest(int n, string expectedResult)
        {
            string result = Program121.FizzBuzz(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}