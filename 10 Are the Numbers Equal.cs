//Create a function that takes two integers and checks if they are equal.
using NUnit.Framework;

[TestFixture]
public class Tests
{
	[Test]
	[TestCase(2, 2, Result=true)]
	[TestCase(88, 88, Result=true)]
	[TestCase(36, 35, Result=false)]
	[TestCase(1, 1, Result=true)]
	[TestCase(5, 6, Result=false)]
	public static bool FixedTest(int num1, int num2) =>
		Program.IsEqual(num1, num2);
}
public class Program 
{
	public static bool IsEqual(int num1, int num2)=>num1==num2;
}