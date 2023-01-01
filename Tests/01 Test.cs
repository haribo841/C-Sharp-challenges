using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests1
    {
        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(-3, -6, -9)]
        [TestCase(7, 3, 10)]
        public void FixedTest(int a, int b, int expectedResult)
        {
            int result = Program1.Sum(a, b);// Act
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}