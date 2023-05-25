using Challenges;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class Test105
    {
        [Test]
        public void BasicTests()
        {
            int[] i1 = { 2, 6, 4, 9 };
            int[] i2 = { 4, 1, 1 };
            int[] i3 = { 1, 0, 3, 3, 7, 2, 1 };
            int[] i4 = { 0 };

            int[] o1 = { 8, 24, 16, 36 };
            int[] o2 = { 12, 3, 3 };
            int[] o3 = { 7, 0, 21, 21, 49, 14, 7 };
            int[] o4 = { 0 };

            Assert.AreEqual(o1, Program105.MultiplyByLength(i1));
            Assert.AreEqual(o2, Program105.MultiplyByLength(i2));
            Assert.AreEqual(o3, Program105.MultiplyByLength(i3));
            Assert.AreEqual(o4, Program105.MultiplyByLength(i4));
        }
    }
}