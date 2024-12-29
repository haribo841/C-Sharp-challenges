using Challenges;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

[TestFixture]
public class TestA2401
{
    [Test]
    [TestCase("../../../../Challenges/Advent of Code/2024/test.txt", 11)]
    [TestCase("../../../../Challenges/Advent of Code/2024/input.txt", 1882714)]
    public void FixedTest(string filePath, int expectedResult)
    {
        int result = A2401.DayOne(filePath);
        Assert.That(result, Is.EqualTo(expectedResult), "Sum of calibration values should match");
    }

    [Test]
    [TestCase("../../../../Challenges/Advent of Code/2024/test.txt", 31)]
    [TestCase("../../../../Challenges/Advent of Code/2024/input.txt", 19437052)]
    public void FixedTest2(string filePath, int expectedResult)
    {
        int result = A2401.DayOnePartTwo(filePath);
        Assert.That(result, Is.EqualTo(expectedResult), "Similarity score should match");
    }
}