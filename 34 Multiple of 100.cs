//Create a function that takes an integer and returns true if it's divisible by 100, otherwise return false.
using NUnit.Framework;
using System;
[TestFixture]
public class Tests
{
	[Test]
	public static void DivisibleTest()
	{
		Assert.AreEqual(false, Program.Divisible(1));
		Assert.AreEqual(true, Program.Divisible(100));
		Assert.AreEqual(true, Program.Divisible(1000));
		Assert.AreEqual(true, Program.Divisible(111000));
		Assert.AreEqual(false, Program.Divisible(-1), "Don't forget negatives");
		Assert.AreEqual(true, Program.Divisible(0), "Cover the 0 cases");
		Assert.AreEqual(true, Program.Divisible(-100), "-100 is divisible by 100");
	}
}
public class Program
{
	public static bool Divisible(int number) { }
}