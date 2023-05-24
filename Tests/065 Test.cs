using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests65
    {
        [Test]
        [TestCase(0, 3, 0)]
        [TestCase(1, 3, 1)]
        [TestCase(5, 3, 2)]
        [TestCase(4, 5, 4)]
        [TestCase(218, 5, 3)]

        public void Mod(int a, int b, int expectedResult)
        {
            // Arrange
            int num = a;
            int divisor = b;
            int result = Program65.Mod(num, divisor);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
