//Create a function which returns the number of true values there are in an array.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(new bool[] { true, false, false, true, false }, Result = 2)]
    [TestCase(new bool[] { false, false, false, false }, Result = 0)]
    [TestCase(new bool[] { }, Result = 0)]
    [TestCase(new bool[] { false, false, true, true, false, false, false, true, true, true, true, false, true, true, false }, Result = 8)]
    [TestCase(new bool[] { true, false, true, true, false, false, false, false, false }, Result = 3)]
    [TestCase(new bool[] { false, true, true, false, true, true, false, true, false, true, false, true, false, true, false }, Result = 8)]
    [TestCase(new bool[] { true, false, true, true, true, false, true, true, false, false }, Result = 6)]
    [TestCase(new bool[] { false, false, false, false, true, false, true, false, true, false, false }, Result = 3)]
    [TestCase(new bool[] { true, false, false, false, true, false, false, true, false, false, false }, Result = 3)]
    [TestCase(new bool[] { true, true, false, true, false, false, false, false, true, false }, Result = 4)]
    [TestCase(new bool[] { true, false, true, true, false, true, true, true, true, false, true, false, true, false }, Result = 9)]
    [TestCase(new bool[] { true, false, true, true, true, true, false, true, true, false, true, false, false, false, false }, Result = 8)]
    [TestCase(new bool[] { true, true, false, false, false, false, true, false, true, true, false, true }, Result = 6)]
    public static int FixedTest(bool[] arr)
    {
        return Program.CountTrue(arr);
    }
}
using System;

public class Program
{
    public static int CountTrue(bool[] arr)
    {

    }
}