//Emmy has written a function that returns a greeting to users.
//However, she's in love with Mubashir, and would like to greet him slightly differently.
//She added a special case in her function, but she made a mistake.
//Can you help her?
using System;
using NUnit.Framework;

[TestFixture]
public class Tests {
    [Test]
	
[TestCase("Matt", Result="Hello, Matt!")]
[TestCase("Helen", Result="Hello, Helen!")]
[TestCase("Mubashir", Result="Hello, my Love!")]

public static string FixedTest(string a) {
		Console.WriteLine($"Input: {a}");
        return Program.greeting(a);
    }
}
