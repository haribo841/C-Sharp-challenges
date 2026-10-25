using Challenges.Edabit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests57
    {
        [Test]
        [TestCase("####", true)]
        [TestCase("## ####", false)]
        [TestCase("#", true)]
        [TestCase("# #", false)]
        public void FixedTest(string a, bool expectedResult)
        {
            bool result = Program57.IsSafeBridge(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}