//Create a function that takes a name and returns a greeting in the form of a string.
using System;
using NUnit.Framework;
​
[TestFixture]
public class Tests
{
    [Test]
    [TestCase("Gerald", Result="Hello Gerald!")]
    [TestCase("Fatima", Result="Hello Fatima!")]
    [TestCase("Ed", Result="Hello Ed!")]
    [TestCase("Tiffany", Result="Hello Tiffany!")]
    public static string FixedTest(string a)
    {
        return Program.HelloName(a);
    }
}
public class Program
{
		public static string HelloName(string name)=>"Hello "+a+"!";
}