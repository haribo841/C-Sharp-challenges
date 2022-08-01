//Create a function that takes the age in years and returns the age in days.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests {
	[Test]
	[TestCase(10, Result=3650)]
	[TestCase(0, Result=0)]
	[TestCase(73, Result=26645)]
	public static int CalcAge(int age)
	{
		Console.WriteLine($"Input: {age}");
		return Program.CalcAge(age);
	}
}
public class Program 
{
    public static int CalcAge(int age)=>age*365;
}