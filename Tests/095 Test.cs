using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests95
    {
        [TestCase("NNNN", false)]
        [TestCase("NENESSWW", true)]
        [TestCase("NEESSW", false)]
        [TestCase("EEWE", false)]
        [TestCase("NNSSEEEWWWEW", true)]

        public void BackToHome(string direction, bool expectedResult)
        {
            bool result = Program95.BackToHome(direction);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}