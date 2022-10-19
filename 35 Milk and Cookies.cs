//Christmas Eve is almost upon us, so naturally we need to prepare some milk and cookies for Santa!
//Create a function that accepts year, month and day as integers and returns true if it's Christmas Eve (December 24th) and false otherwise.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase(2013, 12, 24, Result=true)]
  [TestCase(2013, 0, 23 , Result=false)]
  [TestCase(3000, 12, 24, Result=true)]
    public static bool FixedTest(int year, int month, int day)
    {
				Console.WriteLine($"Input: {year}, {month}, {day}");
        return Program.TimeForMilkAndCookies(year, month, day);
    }
}
public class Program
{
    public static bool TimeForMilkAndCookies(int year, int month, int day){}
}
