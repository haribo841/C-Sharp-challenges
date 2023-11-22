using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests150
    {
        [Test]
        [TestCase(7, 5040)]
        [TestCase(1, 1)]
        [TestCase(9, 362880)]
        [TestCase(2, 2)]
        public void FixedTest(int a, int expectedResult)
        {
            int result = Program150.Factorial(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}