//Given a Rubik's Cube with a side length of n, return the number of individual stickers that are needed to cover the whole cube.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(1, Result = 6)]
    [TestCase(2, Result = 24)]
    [TestCase(3, Result = 54)]
    [TestCase(4, Result = 96)]
    [TestCase(5, Result = 150)]
    [TestCase(6, Result = 216)]
    [TestCase(7, Result = 294)]
    [TestCase(8, Result = 384)]
    [TestCase(9, Result = 486)]
    [TestCase(10, Result = 600)]
    [TestCase(11, Result = 726)]
    [TestCase(12, Result = 864)]
    [TestCase(13, Result = 1014)]
    [TestCase(14, Result = 1176)]
    [TestCase(15, Result = 1350)]
    public static int FixedTest(int a)
    {
        return Program.HowManyStickers(a);
    }
}
using System;
public class Program
{
    public static int HowManyStickers(int n) { return n; }
}