using Challenges.Edabit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests58
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
            bool result = Program58.IsLastCharacterN(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}