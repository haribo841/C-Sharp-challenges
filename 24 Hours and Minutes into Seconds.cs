//Write a function that takes two integers (hours, minutes), converts them to seconds, and adds them.
using NUnit.Framework;

public class Tests
{
	 [Test]
	 [TestCase(1, 0, Result=3600)]
	 [TestCase(1, 3, Result=3780)]
	 [TestCase(0, 30, Result=1800)]
	
	 public static int FixedTest(int hours, int minutes)
	 {
		  return Program.Convert(hours, minutes);
	 }
}
public class Program
{
  public static int Convert(int hours, int minutes)=>hours*3600+minutes*60;
  //int a;
  //Console.Write( a = Convert(1, 3));
}
