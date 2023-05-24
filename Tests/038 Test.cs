using System;
using NUnit.Framework;
using System.Collections.Generic;
using Challenges;

namespace Tests
{
    [TestFixture]
    public class Tests38
    {
        [Test]
        public static void FixedTest()
        {
            List<int> myValues = new(new int[] { 1 });
            Assert.That(Loop.PrintArray(1), Is.EqualTo(myValues));

            myValues = new List<int>(new int[] { 1, 2 });
            Assert.That(Loop.PrintArray(2), Is.EqualTo(myValues));

            myValues = new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            Assert.That(Loop.PrintArray(6), Is.EqualTo(myValues));
        }
    }
}