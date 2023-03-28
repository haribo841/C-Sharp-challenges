using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests48
    {
        [Test]
        [TestCase(17, true, false)]
        [TestCase(30, true, false)]
        [TestCase(24, false, true)]
        [TestCase(18, false, true)]
        [TestCase(16, false, false)]
        [TestCase(18, true, false)]
        [TestCase(17, false, false)]
        public void FixedTest(int a, bool b, bool expectedResult)
        {
            // Arrange
            int age = a;
            bool on_break = b;
            bool result = Program48.ShouldServeDrinks(age, on_break);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}