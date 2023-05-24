using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests94
    {
        [TestCase(new string[] { "abc", "ghj", "banana", "grape" }, "grape", 3)]
        [TestCase(new string[] { "a", "b", "c", "d", "e", "f" }, "f", 5)]
        [TestCase(new string[] { "hi", "edabit.com", "testcase", "validstring" }, "edabit.com", 1)]
        public void FindIndex(string[] arr, string str, int expectedResult)
        {
            int result = Program94.FindIndex(arr, str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}