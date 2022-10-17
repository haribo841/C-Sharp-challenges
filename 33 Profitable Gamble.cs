//Create a function that takes three arguments prob, prize, pay and returns true if prob * prize > pay; otherwise return false.
using NUnit.Framework;
using System;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(0.2, 50, 9, Result = true)]
    [TestCase(0.9, 1, 2, Result = false)]
    [TestCase(0.9, 3, 2, Result = true)]
    [TestCase(0.33, 10, 3.30, Result = true)]
    [TestCase(0, 1000, 0.01, Result = false)]
    [TestCase(0.1, 1000, 7, Result = true)]
    [TestCase(0, 0, 0, Result = false)]
    public static bool ProfitableGamble(double prob, int prize, double pay)
    {
        Console.WriteLine($"Input: {prob}, {prize}, {pay}");
        return Program.ProfitableGamble(prob, prize, pay);
    }
}
public class Program
{
    public static bool ProfitableGamble(double prob, int prize, double pay) { }
}