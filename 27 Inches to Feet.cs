//Create a function that accepts a measurement value in inches and returns the equivalent of the measurement value in feet.
using NUnit.Framework;

public class Tests
{
	 [Test]
	 [TestCase(12, Result=1)]
	 [TestCase(360, Result=30)]
	 [TestCase(3612, Result=301)]
	 [TestCase(324, Result=27)]
	 [TestCase(3012, Result=251)]
	 [TestCase(11, Result=0)]
	
	 public static int FixedTest(int inches)
	 {
		  return Program.inchesToFeet(inches);
	 }
}
public class Program 
{
  public static int inchesToFeet(int inches) {}
}
