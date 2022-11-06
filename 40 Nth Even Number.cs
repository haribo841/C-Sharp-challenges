//Create a function that takes a number n and returns the nth even number beginning with 0 as the first.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(1, Result = 0)]
    [TestCase(2, Result = 2)]
    [TestCase(3, Result = 4)]
    [TestCase(100, Result = 198)]
    [TestCase(1298734, Result = 2597466)]

    public static int Points(int n)
    {
        Console.WriteLine($"Input: {n}");
        return Program.NthEven(n);
    }
}
public class Program
{
    public static int NthEven(int n)
    {

    }
}