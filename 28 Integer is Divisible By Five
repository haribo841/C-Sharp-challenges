//Create a function that returns true if an integer is evenly divisible by 5, and false otherwise.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
	[Test]
	[TestCase(7, Result=false)]
	[TestCase(5, Result=true)]
	[TestCase(15, Result=true)]
	[TestCase(33, Result=false)]
	[TestCase(-18, Result=false)]
	[TestCase(999, Result=false)]
	[TestCase(2, Result=false)]
	public static bool divisibleByFive(int x)
	{
		Console.WriteLine($"Input: {x}");
		return Program.divisibleByFive(x);
	}
}
