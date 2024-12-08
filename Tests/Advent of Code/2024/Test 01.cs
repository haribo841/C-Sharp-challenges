using Challenges;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

[TestFixture]
public class TestA2401
{
    [Test]
    [TestCase("../../../../Challenges/Advent of Code/2023/test.txt", 142)]
    [TestCase("../../../../Challenges/Advent of Code/2023/input.txt", 54877)]
    public void FixedTest(string filePath, int expectedResult)
    {
        int result = A2301.Trebuchet(filePath);
        Assert.That(result, Is.EqualTo(expectedResult), "Sum of calibration values should match");
    }

    [Test]
    [TestCase("../../../../Challenges/Advent of Code/2023/test2.txt", 281)]
    //[TestCase("../../../../Challenges/Advent of Code/2023/input.txt", 54877)]
    public void FixedTest2(string filePath, int expectedResult)
    {
        int result = A2301.Trebuchet2(filePath);
        Assert.That(result, Is.EqualTo(expectedResult), "Sum of calibration values should match");
    }
}