//Create a function that takes an integer and returns true if it's divisible by 100, otherwise return false.
using NUnit.Framework;
using System;
[TestFixture]
public class Tests
{
	[Test]
    [TestCase(1, false)]
    [TestCase(100, true)]
    [TestCase(1000, true)]
    [TestCase(111000, true)]
    [TestCase(-1, false)]
    [TestCase(0, true)]
    [TestCase(-100, true)]
    public static void DivisibleTest(int number)
	{
        bool result = Program34.Divisible(number);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}