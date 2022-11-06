//Create a function that calculates the area of a rectangle.
//If the arguments are invalid, your function must return -1.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
	[Test]
	[TestCase(5, 3, Result=15)]
	[TestCase(8, 5, Result=40)]
	[TestCase(5, 4, Result=20)]
	[TestCase(2, 3, Result=6)]
	[TestCase(10000, 10000, Result=100000000)]
	[TestCase(-2, -5, Result=-1)]
	[TestCase(0, 3, Result=-1)]
	[TestCase(5, -3, Result=-1)]
	[TestCase(0, 1, Result=-1)]
	[TestCase(-1, 0, Result=-1)]
	public static int area(int h, int w)
	{
		Console.WriteLine($"Input: {h}, {w}");
		return Program.area(h, w);
	}
}
public class Program
{
	public static int area(int h, int w){}
}
