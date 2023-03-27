using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests47
    {
        [Test]
        [TestCase(-4, -4)]
        [TestCase(212, -212)]
        [TestCase(-125, -125)]
        [TestCase(932123, -932123)]

        public void ReturnNegative(int n, int expectedResult)
        {
            int result = Program47.ReturnNegative(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}