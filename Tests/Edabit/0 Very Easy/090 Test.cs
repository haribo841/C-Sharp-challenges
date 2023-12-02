using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests90
    {
        [Test]
        [TestCase(new object[] { "tt" }, 1)]
        [TestCase(new object[] { "lama", "tiger", 6 }, 3)]
        [TestCase(new object[] { "love" }, 1)]
        [TestCase(new object[] { 1, 3, 3 }, 3)]
        [TestCase(new object[] { new int[] { 1 }, 3, "ygg" }, 3)]
        public static void FixedTest(object[] p, int expectedResult)
        {
            int result = Program90.NumArgs(p);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}