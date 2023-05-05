using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests85
    {
        [Test]
        [TestCase(new int[] { 1, 5, 9 }, 855)]
        [TestCase(new int[] { 3, 4, 5 }, 216)]
        [TestCase(new int[] { 1, 1, 1 }, 3)]
        [TestCase(new int[] { 32 }, 32768)]
        public void CubesSum(int[] nums_arr, int expectedResult)
        {
            int result = Program85.CubesSum(nums_arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}