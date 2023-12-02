//Write a function that returns 0 if the input is 1, and returns 1 if the input is 0.
using Challenges.Edabit;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests83
    {
        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 0)]
        public void FixedTest(int a, int expectedResult)
        {
            int result = Program83.Flip(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}