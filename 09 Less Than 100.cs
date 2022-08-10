//Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.
using NUnit.Framework;

[TestFixture]
public class Tests
{
	[Test]
	[TestCase(5,57, Result=true)]
	[TestCase(77,30, Result=false)]
	[TestCase(0,59, Result=true)]
	[TestCase(78,35, Result=false)]
	[TestCase(63,11, Result=true)]
	[TestCase(37,99, Result=false)]
	[TestCase(52,11, Result=true)]
	[TestCase(82,95, Result=false)]
	[TestCase(17,44, Result=true)]
	[TestCase(74,53, Result=false)]
	[TestCase(3,77, Result=true)]
	[TestCase(25,80, Result=false)]
	[TestCase(59,28, Result=true)]
	[TestCase(69,87, Result=false)]
	[TestCase(10,45, Result=true)]
	[TestCase(43,58, Result=false)]
	[TestCase(50,44, Result=true)]
	[TestCase(74,89, Result=false)]
	[TestCase(3,27, Result=true)]
	[TestCase(21,79, Result=false)]
	
  public static bool FixedTest(int a, int b) 
    {
        return Program.lessThan100(a,b);
    }
}
public class Program 
{
    public static bool lessThan100(int a, int b)=>a+b<100;
}