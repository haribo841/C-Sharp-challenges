using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests163
    {
        [Test]
        [TestCase(new double[] { }, new double[] { })]
        [TestCase(new double[] { 1 }, new double[] { 1 })]
        [TestCase(new double[] { 1, 2, 3 }, new double[] { 1, 3, 6 })]
        [TestCase(new double[] { -1, -2, -3 }, new double[] { -1, -3, -6 })]
        [TestCase(new double[] { 1, -2, 3 }, new double[] { 1, -1, 2 })]
        [TestCase(new double[] { 3, 3, -2, 408, 3, 3, 0, 66, 2, -2, 2, 3, 4, 2, -47, 3, 3, 2 }, new double[] { 3, 6, 4, 412, 415, 418, 418, 484, 486, 484, 486, 489, 493, 495, 448, 451, 454, 456 })]
        public void FixedTest(double[] arr, double[] expectedResult)
        {
            double[] result = Program163.CumulativeSum(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}