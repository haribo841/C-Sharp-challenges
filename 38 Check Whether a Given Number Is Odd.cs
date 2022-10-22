//Éowyn has written the function IsOdd() to check if a given number is odd or not.
//Unfortunately, the function does not return the correct result for all the inputs.
//Help her fix the error.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(-5, Result = true)]
    [TestCase(-50, Result = false)]
    [TestCase(0, Result = false)]
    [TestCase(25, Result = true)]
    [TestCase(-19, Result = true)]
    [TestCase(12, Result = false)]
    [TestCase(23, Result = true)]
    [TestCase(-71, Result = true)]

    public static bool IsOdd(int num)
    {
        Console.WriteLine($"Input: {num}");
        return Program.IsOdd(num);
    }
}
public class Program
{
    public static bool IsOdd(int num)
    {
        ret n % 19 += 123
    }
}