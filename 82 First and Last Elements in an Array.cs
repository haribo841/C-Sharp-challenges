//Create a function that takes an array of values and returns the first and last values in a new array.
using NUnit.Framework;

[TestFixture]
public class Tests
{
	[Test]
	public static void FirstLast()
	{
		Assert.AreEqual(new object[]{ 5, 25 }, Program.FirstLast(new object[]{ 5, 10, 15, 20, 25 }));
		Assert.AreEqual(new object[]{ "edabit", true }, Program.FirstLast(new object[]{ "edabit", 13, null, false, true }));
		Assert.AreEqual(new object[]{ "", null }, Program.FirstLast(new object[]{ "", 4, "6", "hello", null }));
		Assert.AreEqual(new object[]{ "hello", "com" }, Program.FirstLast(new object[]{ "hello", "edabit", "dot", "com" }));
		Assert.AreEqual(new object[]{ 3, 1 }, Program.FirstLast(new object[]{ 3, 2, 1 }));
		Assert.AreEqual(new object[]{ "one", "two" }, Program.FirstLast(new object[]{ "one", "two" }));
		Assert.AreEqual(new object[]{ false, false }, Program.FirstLast(new object[]{ false, false, true, false, false, true, false }));
	}
}
public class Program
{
	public static object[] FirstLast(object[] values)
	{
		
	}
}
