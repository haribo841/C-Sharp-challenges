//Create a function that takes a number as an argument, increments the number by +1 and returns the result.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase(2, Result=3)]
  [TestCase(-9 , Result=-8)]
  [TestCase(0, Result=1)]
	[TestCase(100, Result=101)]
	[TestCase(999, Result=1000)]
	[TestCase(73, Result=74)]
    public static int FixedTest(int num)
    {
				Console.WriteLine($"Input: {num}");
        return Program.Addition(num);
    }
}
public class Program
{
    public static int Addition(int num)=>num+1;
}