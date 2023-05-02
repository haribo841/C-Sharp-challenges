//Write a function that returns 0 if the input is 1, and returns 1 if the input is 0.
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(0, Result=1)]
    [TestCase(1,  Result=0)]
    public static int FixedTest(int a)
    {
        return Program.Flip(a);
    }
}
public class Program
{
	public static int Flip(int y)
	{
		
	}
}
