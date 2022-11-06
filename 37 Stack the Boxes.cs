//Here's an image of four models. Some of the cubes are hidden behind other cubes.
//Model one consists of one cube. Model two consists of four cubes, and so on...
//Write a function that takes a number n and returns the number of stacked boxes in a model n levels high, visible and invisible.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(1, Result=1)]
    [TestCase(2, Result=4)]
  	[TestCase(0, Result=0)]
		[TestCase(5, Result=25)]
		[TestCase(27, Result=729)]
		[TestCase(196, Result=38416)]
		[TestCase(512, Result=262144)]
    public static int FixedTest(int a)
    {
        return Program.StackBoxes(a);
    }
}
using System;
public class Program
{
	public static int StackBoxes(int n){}
}
