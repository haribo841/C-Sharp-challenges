//Create a function that takes two numbers as arguments and returns their sum.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(2, 3, Result=5)]
    [TestCase(-3, -6, Result=-9)]
  	[TestCase(7, 3, Result=10)]
    public static int FixedTest(int a, int b)
    {
				Console.WriteLine($"Input: {a}, {b}");
        return Program.Sum(a, b);
    }
}
public class Program
{
    public static int Sum(int a, int b)
    {
			return a+b;
    }
}