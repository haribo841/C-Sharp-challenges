//Create a function that takes the month and year (as integers) and returns the number of days in that month.
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(1, 2018, 31)]
    [TestCase(2, 2018, 28)]
    [TestCase(3, 2018, 31)]
    [TestCase(4, 2018, 30)]
    [TestCase(5, 2018, 31)]
    [TestCase(6, 2018, 30)]
    [TestCase(7, 2018, 31)]
    [TestCase(8, 2018, 31)]
    [TestCase(9, 2018, 30)]
    [TestCase(10, 2018, 31)]
    [TestCase(11, 2018, 30)]
    [TestCase(12, 2018, 31)]
    [TestCase(2, 2004, 29)]
    [TestCase(2, 1800, 28)]
    [TestCase(2, 1600, 29)]
    public static int FixedTest(int month, int year