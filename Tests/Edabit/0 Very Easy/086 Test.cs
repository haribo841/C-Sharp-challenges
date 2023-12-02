using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests86
    {
        [Test]
        [TestCase(new int[] { 1, 3, 5 }, new int[] { 2, 6, 8 }, new int[] { 1, 3, 5, 2, 6, 8 })]
        [TestCase(new int[] { 7, 8 }, new int[] { 10, 9, 1, 1, 2 }, new int[] { 7, 8, 10, 9, 1, 1, 2 })]
        [TestCase(new int[] { 4, 5, 1 }, new int[] { 3, 3, 3, 3, 3 }, new int[] { 4, 5, 1, 3, 3, 3, 3, 3 })]

        public void FixedTest(int[] arr1, int[] arr2, int[] expectedResult)
        {
            int[] result = Program86.ConcatArrays(arr1, arr2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}