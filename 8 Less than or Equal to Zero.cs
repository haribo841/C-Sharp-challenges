//Create a function that takes a number as its only argument and returns true if it's less than or equal to zero, otherwise return false.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase(5, Result=false)]
  [TestCase(0, Result=true)]
  [TestCase(-5, Result=true)]
  [TestCase(1, Result=false)]
  [TestCase(2, Result=false)]
  [TestCase(1000, Result=false)]
  [TestCase(0.5, Result=false)]
    public static bool FixedTest(double a)
    {
				Console.WriteLine($"Input: {a}");
        return Program.LessThanOrEqualToZero(a);
    }
}
public class Program 
{
    public static bool LessThanOrEqualToZero(double a)=>a<=0?true:false;
}