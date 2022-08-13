//Create a function that returns true when num1 is equal to num2; otherwise return false.
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(4, 8, Result=false)]
		[TestCase(111, 111, Result=true)]
    [TestCase(2, 5, Result=false)]
  	[TestCase(0, 6, Result=false)]
		[TestCase(10, 10, Result=true)]
	
    public static bool FixedTest(int a, int b)
    {
        return Program.IsSameNum(a,b);
    }
}
public class Program
{
    public static bool IsSameNum(int num1, int num2)=>num1==num2;
	//bool a;
    //Console.Write( a = IsSameNum(4,8));
}