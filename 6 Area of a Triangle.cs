//Write a function that takes the base and height of a triangle and return its area.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
	[Test]
	[TestCase(3, 2, Result=3)]
	[TestCase(5, 4, Result=10)]
	[TestCase(10, 10, Result=50)]
	[TestCase(0, 60, Result=0)]
	[TestCase(12, 11, Result=66)]
	public static int triArea(int b, int h)
	{
		Console.WriteLine($"Input: {b}, {h}");
		return Program.triArea(b, h);
	}
}
public class Program
{
	public static int triArea(int b, int h)=>(b*h)/2;
}