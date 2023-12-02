using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests158
    {
        [Test]
        [TestCase(new double[] { 1, 5, 8, 2, 3, 4, 4, 4, 10 }, new double[] { 1, 2, 3, 4, 5, 8, 10 })]
        [TestCase(new double[] { 1, 2, 5, 4, 7, 7, 7 }, new double[] { 1, 2, 4, 5, 7 })]
        [TestCase(new double[] { 7, 6, 5, 4, 3, 2, 1, 0, 1 }, new double[] { 0, 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new double[] { 3, 6, 5, 4, 3, 27, 1, 100, 1 }, new double[] { 1, 3, 4, 5, 6, 27, 100 })]
        [TestCase(new double[] { -9, -3.1414, -87, 8, -4.323827, -3.1415, -3.1415 }, new double[] { -87, -9, -4.323827, -3.1415, -3.1414, 8 })]
        public void FixedTest(double[] arr, double[] expectedResult)
        {
            double[] result = Program158.UniqueSort(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}