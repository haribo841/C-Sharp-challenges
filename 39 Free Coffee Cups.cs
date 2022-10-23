//For each of the 6 coffee cups I buy, I get a 7th cup free. In total, I get 7 cups.
//Create a function that takes n cups bought and return the total number of cups I would get.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
	[Test]
	[TestCase(6, Result = 7)]
	[TestCase(3, Result = 3)]
	[TestCase(7, Result = 8)]
	[TestCase(12, Result = 14)]
	[TestCase(213, Result = 248)]
	[TestCase(16, Result = 18)]
	public static int FixedTest(int n)
	{
		Console.WriteLine($"Input: {n}");
		return Program.TotalCups(n);
	}
}
public class Program
{
	public static int TotalCups(int n)	{}
}