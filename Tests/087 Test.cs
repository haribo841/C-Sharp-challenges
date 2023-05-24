using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests87
    {
        [Test]
        [TestCase("WHAT DO YOU MEAN WE'RE OUT OF MONEY", "WHAT DO YOU WEAN WE'RE OUT OF WONEY")]
        [TestCase("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "ABCDEFGHIJKLWNOPQRSTUVWXYZ")]
        [TestCase("1 WUMBO 2 WUMBO 3 WUMBO 4", "1 WUWBO 2 WUWBO 3 WUWBO 4")]
        public void FixedTest(string a, string expectedResult)
        {
            string result = Program87.Wumbo(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}