using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests90
    {

        [TestFixture]
        public class Tests
        {
            [Test]
            [TestCase("tt", ExpectedResult = 1, TestName = "Test 1")]
            [TestCase("lama", "tiger", 6, ExpectedResult = 3, TestName = "Test 2")]
            [TestCase("love", ExpectedResult = 1, TestName = "Test 3")]
            [TestCase(1, 3, 3, ExpectedResult = 3, TestName = "Test 4")]
            [TestCase(new int[] { 1 }, 3, "ygg", ExpectedResult = 3, TestName = "Test 5")]
            public static int FixedTest(params object[] p)
            {
                Console.WriteLine($"Input: {p}");
                return Program90.NumArgs(p);
            }
        }
    }
}