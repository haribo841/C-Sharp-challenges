//Create a function that takes the number of wins,
//draws and losses and calculates the number of points a football team has obtained so far.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(1, 2, 3, Result=5)]
    [TestCase(5, 5, 5, Result=20)]
  	[TestCase(1, 0, 0, Result=3)]
		[TestCase(0, 7, 0, Result=7)]
		[TestCase(0, 0, 15, Result=0)]
    public static int FixedTest(int a, int b, int c)
    {
				Console.WriteLine($"Input: {a}, {b}, {c}");
        return Program.FootballPoints(a, b, c);
    }
}
public class Program
{
    public static int FootballPoints(int wins, int draws, int losses)=>wins*3+draws;
	//int a;
    //Console.Write( a = FootballPoints(3, 4, 2));
}