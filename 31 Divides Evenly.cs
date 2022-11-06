//Given two integers, a and b, return true if a can be divided evenly by b. Return false otherwise.
using NUnit.Framework;

[TestFixture]
public class Tests
{
	[Test]
	
	[TestCase(98,7, Result=true)]
	[TestCase(87,49, Result=false)]
	[TestCase(34,14, Result=false)]
	[TestCase(78,6, Result=true)]
  [TestCase(30,4, Result=false)]
	[TestCase(87,73, Result=false)]
	[TestCase(74,7, Result=false)]
	[TestCase(87,29, Result=true)]
	[TestCase(48,24, Result=true)]
	[TestCase(99,20, Result=false)]
	[TestCase(98,49, Result=true)]
	[TestCase(100,6, Result=false)]
	[TestCase(64,4, Result=true)]
	[TestCase(70,35, Result=true)]
	[TestCase(38,38, Result=true)]
	[TestCase(29,3, Result=false)]
	[TestCase(20,8, Result=false)]
	[TestCase(66,50, Result=false)]
	[TestCase(95,1, Result=true)]
	[TestCase(58,2, Result=true)]
	
  public static bool FixedTest(int a, int b) 
    {
        return Program.dividesEvenly(a,b);
    }
}
public class Program 
{
	public static bool dividesEvenly(int a, int b) {}
}
