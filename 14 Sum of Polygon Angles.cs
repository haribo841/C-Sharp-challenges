//Given an n-sided regular polygon n, return the total sum of internal angles (in degrees).
using System;
using NUnit.Framework;

[TestFixture]
public class Tests {
	[Test]
	[TestCase(21, Result=3420)]
	[TestCase(22, Result=3600)]
	[TestCase(3, Result=180)]
	[TestCase(4, Result=360)]
	[TestCase(5, Result=540)]
	[TestCase(6, Result=720)]
	[TestCase(7, Result=900)]
	[TestCase(8, Result=1080)]
	[TestCase(9, Result=1260)]
	[TestCase(10, Result=1440)]
	[TestCase(11, Result=1620)]
	[TestCase(12, Result=1800)]
	[TestCase(13, Result=1980)]
	[TestCase(14, Result=2160)]
	[TestCase(15, Result=2340)]
	[TestCase(16, Result=2520)]
	[TestCase(17, Result=2700)]
	[TestCase(18, Result=2880)]
	[TestCase(19, Result=3060)]
	[TestCase(20, Result=3240)]
	
	public static int SumPolygon(int num)
	{
		Console.WriteLine($"Input: {num}");
		return Program.SumPolygon(num);
	}
}
public class Program {
	public static int SumPolygon(int num)=> (num - 2)*180;
}