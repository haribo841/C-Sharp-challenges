using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests69
    {
        [Test]
        [TestCase(24, 100, "-", -76)]
        [TestCase(-20, -30, "+", -50)]
        [TestCase(38, 3, "*", 114)]
        [TestCase(49, 5, "%", 4)]
        [TestCase(1500, 5, "/", 300)]
        public void Calculate(int num1, int num2, string operation, int expectedResult)
        {
            int result = Program69.Calculate(num1, num2, operation);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}