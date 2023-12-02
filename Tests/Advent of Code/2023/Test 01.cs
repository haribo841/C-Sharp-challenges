using Challenges;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

[TestFixture]
public class TestA2301
{
    [Test]
    [TestCase("../test.txt", 142)]
    public void FixedTest(string filePath, int expectedResult)
    {
        int result = A2301.Trebuchet(filePath);
        Assert.That(result, Is.EqualTo(expectedResult), "Sum of calibration values should match");
    }
}