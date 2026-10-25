using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests56
    {
        [Test]
        [TestCase(3, "odd")]
        [TestCase(0, "even")]
        [TestCase(7, "odd")]
        [TestCase(12, "even")]
        [TestCase(6474, "even")]
        [TestCase(563, "odd")]
        [TestCase(3, "odd")]
        [TestCase(301, "odd")]
        [TestCase(-3, "odd")]
        [TestCase(-0, "even")]
        [TestCase(-7, "odd")]
        [TestCase(-12, "even")]
        [TestCase(-563, "odd")]
        [TestCase(-6474, "even")]
        [TestCase(-3, "odd")]
        [TestCase(-301, "odd")]
        public void FixedTest(int num, string expectedResult)
        {
            string result = Program56.IsEvenOrOdd(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}