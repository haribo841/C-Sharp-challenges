//Write a function that takes an integer minutes and converts it to seconds.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests {
	[Test]
	[TestCase(6, Result=360)]
	[TestCase(4, Result=240)]
	[TestCase(8, Result=480)]
	[TestCase(60, Result=3600)]
	public static int FixedTest(int a) {
		Console.WriteLine($"Input: {a}");
		return Program.convert(a);
	}
}
public class Program {
	public static int convert(int minutes)=>minutes*60;
}