//Look at the examples below to get an idea of what the function should do.
using System;
using NUnit.Framework;
using System.Collections.Generic;
namespace Tests
{
    [TestFixture]
    public class Tests38
    {
        [Test]
        public static void FixedTest()
        {
            List<int> myValues = new List<int>(new int[] { 1 });
            Assert.That(Loop.PrintArray(1), Is.EqualTo(myValues));

            myValues = new List<int>(new int[] { 1, 2 });
            Assert.That(Loop.PrintArray(2), Is.EqualTo(myValues));

            myValues = new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            Assert.That(Loop.PrintArray(6), Is.EqualTo(myValues));
        }
    }
}