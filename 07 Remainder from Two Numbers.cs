/*There is a single operator in C#, capable of providing the remainder of a division operation.
Two numbers are passed as parameters. The first parameter divided by the second parameter will
have a remainder, possibly zero. Return that value.*/
using NUnit.Framework;
using System;

[TestFixture]
public class Tests
{
		[Test]
		[TestCase(7, 2, Result=1)]
		[TestCase(3, 4, Result=3)]
		[TestCase(-9, 45, Result=-9)]
		[TestCase(5, 5, Result=0)]
    public static int Remainder(int x, int y) 
    {
				Console.WriteLine($"Input: {x}, {y}");
        return Program.Remainder(x, y);
    }
}
public class Program 
{
    public static int Remainder(int x, int y)=>x%y;
}