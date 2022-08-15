//C# has a logical operator &&. The && operator takes two boolean values, and returns true if both values are true.
//Consider a && b:
//a is checked if it is true or false.
//If a is false, false is returned.
//b is checked if it is true or false.
//If b is false, false is returned.
//Otherwise, true is returned (as both a and b are therefore true ).
//Rembember that the default value for bool is false. (eg. var c = new bool(); c is false.)
//The && operator will only return true for true && true.
//Make a function using the && operator.
using NUnit.Framework;
using System;

[TestFixture]
public class Tests
{
		[Test]
		[TestCase(true, true, Result=true)]
		[TestCase(true, false, Result=false)]
		[TestCase(false, true, Result=false)]
		[TestCase(false, false, Result=false)]
    public static bool And(bool x, bool y) 
    {
				Console.WriteLine($"Input: {x}, {y}");
        return Program.And(x, y);
    }
}
public class Program
{
	public static bool And(bool x, bool y)=>x&&y;
   // bool a;
   //Console.Write( a = And(true,true));
}