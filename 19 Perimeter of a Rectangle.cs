//Create a function that takes length and width and finds the perimeter of a rectangle.
using NUnit.Framework;

public class Tests
{
	 [Test]
	 [TestCase(6, 7, Result=26)]
	 [TestCase(20,10, Result=60)]
	 [TestCase(2,9, Result=22)]
	
	 public static int FixedTest(int length, int width)
	 {
		  return Program.FindPerimeter(length, width);
	 }
}
public class Program 
{
  public static int FindPerimeter(int length, int width)=>length*2+width*2;
  //int a;
  //Console.Write( a = FindPerimeter(69,420));
}