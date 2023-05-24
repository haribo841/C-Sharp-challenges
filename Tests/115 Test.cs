using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests115
    {
        [Test]
        [TestCase(new double[] { 6, 3 }, 2)]
        [TestCase(new double[] { 6, 3, 6 }, 1.5)]
        [TestCase(new double[] { 10, 10 }, 5)]
        [TestCase(new double[] { 10, 20, 10 }, 4)]
        [TestCase(new double[] { 60, 30, 20 }, 10)]
        [TestCase(new double[] { 16, 4 }, 3.2)]
        [TestCase(new double[] { 20, 5 }, 4)]
        [TestCase(new double[] { 500, 500, 500 }, 166.7)]
        [TestCase(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0.3)]

        public void ParallelResistance(double[] arr, double expectedResult)
        {
            double result = Program115.ParallelResistance(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
