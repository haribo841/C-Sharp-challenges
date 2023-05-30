using Challenges;
using NUnit.Framework;

[TestFixture]
public class FindNeedleTest
{
    [Test]
    public void GenericTests()
    {
        int[] haystack_1 = new int[] { 1, 2, 10, 50, 5 };
        int[] haystack_2 = new int[] { 80, 29, 4, -95, -24, 85 };
        int[] haystack_4 = new int[] { };
        int[] haystack_5 = new int[] { 47, 51, -17, -16, 91, 47, -85, -8, -16, -27 };
        int[] haystack_6 = new int[] { -51, -73, 65, 69, -76, 74, -14 };
        int[] haystack_7 = new int[] { 45, 98, 35, 65, 97, 21, 33 };
        int[] haystack_8 = new int[] { -23, -69, -54, -2, -32 };
        int[] haystack_9 = new int[] { -21, -9, -96 };
        int[] haystack_10 = new int[] { 0 };

        Assert.AreEqual(new int[] { 1, 2, 5, 10, 50 }, Program111.SortNumsAscending(haystack_1));
        Assert.AreEqual(new int[] { -95, -24, 4, 29, 80, 85 }, Program111.SortNumsAscending(haystack_2));
        Assert.AreEqual(new int[] { }, Program111.SortNumsAscending(haystack_4));
        Assert.AreEqual(new int[] { -85, -27, -17, -16, -16, -8, 47, 47, 51, 91 }, Program111.SortNumsAscending(haystack_5));
        Assert.AreEqual(new int[] { -76, -73, -51, -14, 65, 69, 74 }, Program111.SortNumsAscending(haystack_6));
        Assert.AreEqual(new int[] { 21, 33, 35, 45, 65, 97, 98 }, Program111.SortNumsAscending(haystack_7));
        Assert.AreEqual(new int[] { -69, -54, -32, -23, -2 }, Program111.SortNumsAscending(haystack_8));
        Assert.AreEqual(new int[] { -96, -21, -9 }, Program111.SortNumsAscending(haystack_9));
        Assert.AreEqual(new int[] { 0 }, Program111.SortNumsAscending(haystack_10));
    }
}