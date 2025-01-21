//Create a function that returns true if a string contains any spaces.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public class Program56
    {
        public static bool HasSpaces(string str)
        {
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    return true;
                }
            }
            return false;
        }
    }
    public class BenchmarkProgram56
    {
        [Benchmark]
        [Arguments("Foo")]
        [Arguments("Foo bar")]
        [Arguments("Foo ")]
        [Arguments(" Foo")]
        [Arguments(" ")]
        [Arguments("")]
        [Arguments(",./;'[]-=")]
        public bool HasSpaces(string str) => Program56.HasSpaces(str);
    }
}