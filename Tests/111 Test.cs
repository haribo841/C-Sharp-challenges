using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class FindNeedleTest
    {
        [TestCase(new int[] { 1, 2, 10, 50, 5 }, new int[] { 1, 2, 5, 10, 50 })]
        [TestCase(new int[] { 80, 29, 4, -95, -24, 85 }, new int[] { -95, -24, 4, 29, 80, 85 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 47, 51, -17, -16, 91, 47, -85, -8, -16, -27 }, new int[] { -85, -27, -17, -16, -16, -8, 47, 47, 51, 91 })]
        [TestCase(new int[] { -51, -73, 65, 69, -76, 74, -14 }, new int[] { -76, -73, -51, -14, 65, 69, 74 })]
        [TestCase(new int[] { 45, 98, 35, 65, 97, 21, 33 }, new int[] { 21, 33, 35, 45, 65, 97, 98 })]
        [TestCase(new int[] { -23, -69, -54, -2, -32 }, new int[] { -69, -54, -32, -23, -2 })]
        [TestCase(new int[] { -21, -9, -96 }, new int[] { -96, -21, -9 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void TestSortNumsAscending(int[] haystack, int[] expectedResult)
        {
            int[] result = Program111.SortNumsAscending(haystack);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}