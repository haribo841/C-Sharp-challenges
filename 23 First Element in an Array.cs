//Create a function that takes an array containing only values of the same type and return the first element.
using NUnit.Framework;

[TestFixture]
public class Tests
{
	[Test]
	[TestCase(new object[] {5, 6, 7}, Result=5)]
	[TestCase(new object[] {"Semiramis","Gaia","Hypatia"}, Result="Semiramis")]
	[TestCase(new object[] {-500, 0, 500}, Result=-500)]
	[TestCase(new object[] {'n','m','v'}, Result='n')]
	[TestCase(new object[] {3.3, 4.4, 5.5}, Result=3.3)]
	[TestCase(new object[] {true,false,true}, Result=true)]
	public static object FixedTest(object[] arr)
  {
    return Program.GetFirstValue(arr);
  }
}