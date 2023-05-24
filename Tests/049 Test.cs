using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests49
    {
        [Test]
        [TestCase(-5, 5)]
        [TestCase(-3, 3)]
        [TestCase(250, 250)]
        [TestCase(0, 0)]
        [TestCase(6, 6)]
        [TestCase(1103, 1103)]

        public void FixedTest(int a, int expectedResult)
        {
            // Arrange
            int number = a;
            int result = Program49.Absolute(number);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}