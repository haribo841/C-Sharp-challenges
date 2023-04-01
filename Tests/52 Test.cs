using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests52
    {
        [Test]
        [TestCase("Aiden", true)]
        [TestCase("Roxy", false)]
        [TestCase("Bert", false)]
        [TestCase("Dean", true)]
        [TestCase("Ian", true)]
        [TestCase("Brian", true)]
        [TestCase("Daniel", false)]
        public void FixedTest(string a, bool expectedResult)
        {
            // Arrange
            string word = a;
            bool result = Program51.FixedTest(word);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}