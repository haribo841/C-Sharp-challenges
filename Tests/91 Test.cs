using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests91
    {
        [Test]
        [TestCase(1, 0.01)]
        [TestCase(500, 4.65)]
        [TestCase(649, 6.04)]
        [TestCase(1000, 9.3)]
        public void FixedTest(int a, double expectedResult)
        {
            double result = Program91.YenToUsd(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}