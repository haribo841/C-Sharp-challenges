//Write a function that returns the string "something" joined with a space " " and the given argument a.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests {
    [Test]
		[TestCase("a", Result="something a")]
		[TestCase("is cooking", Result="something is cooking")]
		[TestCase(" is cooking", Result="something  is cooking")]
    public static string FixedTest(string a) {
				Console.WriteLine($"Input: {a}");
        return Program.GiveMeSomething(a);
    }
}
public class Program {
	public static string GiveMeSomething(string a)=>"something "+a;
}