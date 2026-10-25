using Challenges;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

[TestFixture]
public class TestA2301
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

    [TestCase("twone", 21)]
    [TestCase("oneight", 18)]
    [TestCase("eightwo", 82)]
    [TestCase("7pqrstsixteen", 76)]
    [TestCase("0abc9", 9)]
    [TestCase("two1nine\neightwothree", 112)]
    [TestCase("", 0)]
    [TestCase("no digits", 0)]
    public void PartTwoHandlesOverlappingWordsAndNumericDigits(string text, int expected)
    {
        string path = Path.GetTempFileName();
        try
        {
            File.WriteAllText(path, text);
            Assert.That(A2301.Trebuchet2(path), Is.EqualTo(expected));
        }
        finally
        {
            File.Delete(path);
        }
    }
}
