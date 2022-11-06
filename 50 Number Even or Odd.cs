//Create a function that takes a number as an argument and returns "even" for even numbers and"odd" for odd numbers.
using System;
using NUnit.Framework;
[TestFixture]
public class Tests
{
    [Test]
    [TestCase(3, Result = "odd")]
    [TestCase(0, Result = "even")]
    [TestCase(7, Result = "odd")]
    [TestCase(12, Result = "even")]
    [TestCase(6474, Result = "even")]
    [TestCase(563, Result = "odd")]
    [TestCase(3, Result = "odd")]
    [TestCase(301, Result = "odd")]
    [TestCase(-3, Result = "odd")]
    [TestCase(-0, Result = "even")]
    [TestCase(-7, Result = "odd")]
    [TestCase(-12, Result = "even")]
    [TestCase(-563, Result = "odd")]
    [TestCase(-6474, Result = "even")]
    [TestCase(-3, Result = "odd")]
    [TestCase(-301, Result = "odd")]
    public static string FixedTest(int num)
    {
        Console.WriteLine($"Input: {num}");
        return Program.IsEvenOrOdd(num);
    }
}
public class Program
{
    public static string IsEvenOrOdd(int num)
    {

    }
}