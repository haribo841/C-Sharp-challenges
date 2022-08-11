//Write a function that converts hours into seconds.
using NUnit.Framework;

public class Tests
{
	  [Test]
	  [TestCase(2, Result=7200)]
	  [TestCase(10, Result=36000)]
	  [TestCase(24, Result=86400)]
	  [TestCase(36, Result=129600)]
	
	  public static int FixedTest(int hours)
		{
			  return Program.HowManySeconds(hours);
		}
}
public class Program
{
	public static int HowManySeconds(int hours)=>hours*3600;
}