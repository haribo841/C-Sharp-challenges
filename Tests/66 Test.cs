using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests66
{
    [Test]
    [TestCase(new double[] { 34, 15, 88, 2 }, 2)]
    [TestCase(new double[] { 34, -345, -1, 100 }, -345)]
    [TestCase(new double[] { -76, 1.345, 1, 0 }, -76)]
    [TestCase(new double[] { 0.4356, 0.8795, 0.5435, -0.9999 }, -0.9999)]
    [TestCase(new double[] { 7, 7, 7 }, 7)]
    [TestCase(new double[] { 4, 6, 1, 3, 4, 5, 5, 1 }, 1)]
    [TestCase(new double[] { -4, -6, -8, -1 }, -8)]
    [TestCase(new double[] { 54, 76, 23, 54 }, 23)]
    [TestCase(new double[] { 100 }, 100)]
    [TestCase(new double[] { 0, 1, 2, 3, 4, 5 }, 0)]

    public void FixedTest(double[] arr, object expectedResult)
    {
            object result = Program66.FindSmallestNum(arr);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
}