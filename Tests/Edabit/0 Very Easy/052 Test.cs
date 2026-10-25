using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests52
    {
        [Test]
        [TestCase("apples", true)]
        [TestCase("banana", true)]
        [TestCase("cherry", true)]
        [TestCase("mango", false)]
        [TestCase("peach", false)]
        [TestCase("pears", false)]

        public void FixedTest(string word, bool expectedResult)
        {
            bool result = Program52.OddOrEven(word);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}