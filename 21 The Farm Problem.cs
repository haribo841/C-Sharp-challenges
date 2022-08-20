//In this challenge, a farmer is asking you to tell him how many legs can be counted among all his animals.
//The farmer breeds three species:
//chickens = 2 legs
//cows = 4 legs
//pigs = 4 legs
//The farmer has counted his animals and he gives you a subtotal for each species.
//You have to implement a function that returns the total number of legs of all the animals.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
	[Test]
	[TestCase(5, 2, 8, Result=50)]
	[TestCase(3, 4, 7, Result=50)]
	[TestCase(1, 2, 3, Result=22)]
	[TestCase(3, 5, 2, Result=34)]
	public static int animals(int a, int b, int c)
	{
		Console.WriteLine($"Input: {a}, {b}, {c}");
		return Program.animals(a, b, c);
	}
}
public class Program
{
	public static int animals(int chickens, int cows, int pigs)=>chickens*2+(cows+pigs)*4;
    //int a;
    //Console.Write( a = animals(5,2, 8));
}