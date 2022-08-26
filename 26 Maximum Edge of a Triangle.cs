//Create a function that finds the maximum range of a triangle's third edge, where the side lengths are all integers.
using NUnit.Framework;

public class Tests
{
	 [Test]
	 [TestCase(5,4, Result=8)]
	 [TestCase(8,3, Result=10)]
	 [TestCase(7,9, Result=15)]
	 [TestCase(10,4, Result=13)]
	 [TestCase(7,2, Result=8)]
	
	 public static int FixedTest(int side1, int side2)
	 {
		  return Program.NextEdge(side1, side2);
	 }
}
public class Program
{
  public static int NextEdge(int side1, int side2) {}
}
