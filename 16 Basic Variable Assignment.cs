//A student learning C# was trying to make a function.
//His code should concatenate a passed string name with string "Edabit" and store it in a variable called result.
//He needs your help to fix this code.
using System;
using NUnit.Framework;

[TestFixture]
public class Tests {
    [Test]
		[TestCase("Mubashir", Result="MubashirEdabit")]
		[TestCase("Matt", Result="MattEdabit")]
		[TestCase("C#", Result="C#Edabit")]
		[TestCase("Airforce", Result="AirforceEdabit")]
    public static string FixedTest(string a) {
				Console.WriteLine($"Input: {a}");
        return Program.nameString(a);
    }
}
         static string nameString(string name)
         {
              string b = "Edabit";
              string result = name + b;
              return result;
         }
         //string a;
         //Console.Write( a = nameString("name"));