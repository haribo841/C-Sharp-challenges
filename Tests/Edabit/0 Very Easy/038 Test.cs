using System;
using NUnit.Framework;
using System.Collections.Generic;
using Challenges.Edabit;

namespace Tests
{
    [TestFixture]
    public class Tests38
    {
        [TestCase(1, new int[] { 1 })]
        [TestCase(2, new int[] { 1, 2 })]
        [TestCase(6, new int[] { 1, 2, 3, 4, 5, 6 })]
        public static void TestPrintArray(int n, int[] expectedValues)
        {
            List<int> myValues = new(expectedValues);
            Assert.That(Loop.PrintArray(n), Is.EqualTo(myValues));
        }
    }
}