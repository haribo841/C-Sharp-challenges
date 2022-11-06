//The Math.Abs() function returns the absolute value of a number.
//This means that it returns a number's positive value.
//You can think of it as the distance away from zero.
//Create a function that recreates this functionality.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(-5, Result = 5)]
    [TestCase(-3, Result = 3)]
    [TestCase(250, Result = 250)]
    [TestCase(0, Result = 0)]
    [TestCase(6, Result = 6)]
    [TestCase(1103, Result = 1103)]

    public static int FixedTest(int a)
    {
        Console.WriteLine($"Input: {a}");
        return Program.absolute(a);
    }
}
public class Program
{
    public static int absolute(int num)
    {

    }
}