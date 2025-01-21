//A student learning C# was trying to make a function.
//His code should concatenate a passed string name with string "Edabit" and store it in a variable called result.
//He needs your help to fix this code.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program16
    {
        public static string NameString(string name)
        {
            string b = "Edabit"; // Use '=' instead of '=='
            string result = name + b; // Use '=' instead of '=='
            return result;
        }
    }
    public class BenchmarkProgram16
    {
        [Benchmark]
        [Arguments("Mubashir")]
        [Arguments("Matt")]
        [Arguments("C#")]
        [Arguments("Airforce")]
        public string NameString(string name) => Program16.NameString(name);
    }
}