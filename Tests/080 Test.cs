using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests80
    {
        [Test]
        [TestCase(new double[] { 1, 5, 6, 3 }, "15 ohms")]
        [TestCase(new double[] { 0.2, 0.3, 0.4 }, "0.9 ohm")]
        [TestCase(new double[] { 10, 12, 1, 10 }, "33 ohms")]
        [TestCase(new double[] { 10, 13, 3.8, 20, 10 }, "56.8 ohms")]
        [TestCase(new double[] { 0.5, 0.5 }, "1 ohm")]
        [TestCase(new double[] { 16, 30, 22.8, 4 }, "72.8 ohms")]
        [TestCase(new double[] { 20, 15, 32.5, 2 }, "69.5 ohms")]
        [TestCase(new double[] { 52, 22, 20, 30 }, "124 ohms")]
        [TestCase(new double[] { 10, 12, 32, 4.9, 5, 6, 71 }, "140.9 ohms")]

        public void SeriesResistance(double[] arr, string expectedResult)
        {
            string result = Program80.SeriesResistance(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}