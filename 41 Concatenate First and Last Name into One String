//Given two strings, firstName and lastName, return a single string in the format "last, first".
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase("John", "Doe", Result = "Doe, John")]
  [TestCase("First", "Last", Result = "Last, First")]
  [TestCase("A", "B", Result = "B, A")]
	[TestCase(",", ",", Result = ",, ,")]
    public static string FixedTest(string firstName, string lastName)
    {
			Console.WriteLine($"Input: {firstName}, {lastName}");
			return Program.ConcatName(firstName, lastName);
    }
}
public class Program
{
	public static string ConcatName(string firstName, string lastName){}
}
