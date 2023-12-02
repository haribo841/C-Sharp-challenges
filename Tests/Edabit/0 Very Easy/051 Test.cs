using Challenges.Edabit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests51
    {
        [Test]
        [TestCase("####", true)]
        [TestCase("## ####", false)]
        [TestCase("#", true)]
        [TestCase("# #", false)]
        public void FixedTest(string a, bool expectedResult)
        {
            // Arrange
            string bridge = a;
            bool result = Program51.IsSafeBridge(bridge);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}