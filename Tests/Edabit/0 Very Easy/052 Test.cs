using Challenges.Edabit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
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
            bool result = Program52.IsLastCharacterN(word);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}