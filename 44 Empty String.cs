//Create a function that returns true if a string is empty and false otherwise.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase("", Result = true)]
    [TestCase(" ", Result = false)]
    [TestCase("            ", Result = false)]
    [TestCase("38215", Result = false)]
    [TestCase("afjabsdf", Result = false)]
    [TestCase("!?@&", Result = false)]
    public static bool isEmpty(string s)
    {
        Console.WriteLine($"Input: {s}");
        return Program.isEmpty(s);
    }
}
public class Program
{
    public static bool isEmpty(string str)
    {
    }
}