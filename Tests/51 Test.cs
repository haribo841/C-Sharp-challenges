using Challenges;
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
            bool result = Program51.FixedTest(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}