//Create a function that reverses a boolean value.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase(false, Result=true)]
  [TestCase(true, Result=false)]
    public static bool FixedTest(bool boolean)
    {
				Console.WriteLine($"Input: {boolean}");
        return Program.Reverse(boolean);
    }
}
public class Program
{
    public static bool Reverse(bool boolean)=>!boolean;
}