//Create a function that takes voltage and current and returns the calculated power.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests {
	[Test]
	[TestCase(110, 3, Result=330)]
	[TestCase(230, 10, Result=2300)]
	[TestCase(480, 20, Result=9600)]
	
	public static int CircuitPower(int voltage, int current)
	{
		Console.WriteLine($"Input: {voltage} {current}");
		return Program.CircuitPower(voltage, current);
	}
}
public class Program 
{
    public static int CircuitPower(int voltage, int current)=>voltage*current;
}