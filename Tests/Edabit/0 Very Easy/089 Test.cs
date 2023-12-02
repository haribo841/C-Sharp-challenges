using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests89
    {
        [Test]
        [TestCase(new bool[] { true, false, false, true, false }, 2)]
        [TestCase(new bool[] { false, false, false, false }, 0)]
        [TestCase(new bool[] { }, 0)]
        [TestCase(new bool[] { false, false, true, true, false, false, false, true, true, true, true, false, true, true, false }, 8)]
        [TestCase(new bool[] { true, false, true, true, false, false, false, false, false }, 3)]
        [TestCase(new bool[] { false, true, true, false, true, true, false, true, false, true, false, true, false, true, false }, 8)]
        [TestCase(new bool[] { true, false, true, true, true, false, true, true, false, false }, 6)]
        [TestCase(new bool[] { false, false, false, false, true, false, true, false, true, false, false }, 3)]
        [TestCase(new bool[] { true, false, false, false, true, false, false, true, false, false, false }, 3)]
        [TestCase(new bool[] { true, true, false, true, false, false, false, false, true, false }, 4)]
        [TestCase(new bool[] { true, false, true, true, false, true, true, true, true, false, true, false, true, false }, 9)]
        [TestCase(new bool[] { true, false, true, true, true, true, false, true, true, false, true, false, false, false, false }, 8)]
        [TestCase(new bool[] { true, true, false, false, false, false, true, false, true, true, false, true }, 6)]
        public void FixedTest(bool[] arr, int expectedResult)
        {
            int result = Program89.CountTrue(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}