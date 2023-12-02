using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests96
    {
        [TestCase("It's high noon", 3)]
        [TestCase("Is this easy mode", 4)]
        [TestCase("What an easy task, right", 5)]
        [TestCase("This is a test", 4)]
        [TestCase("Just an example here move along", 6)]
        [TestCase("How are you today?", 4)]
        public void FixedTest(string str, int expectedResult)
        {
            int result = Program96.CountWords(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
