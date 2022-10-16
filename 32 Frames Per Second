//Create a function that returns the number of frames shown in a given number of minutes for a certain FPS.
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(1, 1, Result=60)]
    [TestCase(10, 1, Result=600)]
  	[TestCase(10, 25, Result=15000)]
		[TestCase(500, 60, Result=1800000)]
		[TestCase(0, 60, Result=0)]
		[TestCase(99,1, Result=5940)]
		[TestCase(419, 70, Result=1759800)]
		[TestCase(52, 33, Result=102960)]
    public static int FixedTest(int a, int b)
    {
        return Program.Frames(a, b);
    }
}
public class Program
{
    public static int Frames(int minutes, int fps){}
}
