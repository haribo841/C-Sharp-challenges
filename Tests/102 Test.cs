using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests102
    {
        [Test]
        [TestCase(new double[] { 14, 35, 6, 1, 34, 54 }, new double[] { 1, 54 })]
        [TestCase(new double[] { 1.346, 1.6532, 1.8734, 1.8723 }, new double[] { 1.346, 1.8734 })]
        [TestCase(new double[] { 0.432, 0.874, 0.523, 0.984, 0.327, 0.2345 }, new double[] { 0.2345, 0.984 })]
        [TestCase(new double[] { 13, 72, 98, 43, 24, 65, 31 }, new double[] { 13, 98 })]
        [TestCase(new double[] { -54, -23, -54, -21 }, new double[] { -54, -21 })]
        [TestCase(new double[] { -0.473, -0.6834, -0.1287, 0.5632 }, new double[] { -0.6834, 0.5632 })]
        [TestCase(new double[] { 0, 0, 0, 0 }, new double[] { 0, 0 })]
        public void FixedTest(double[] a, double[] expectedResult)
        {
            double[] result = Program102.FindMinMax(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}