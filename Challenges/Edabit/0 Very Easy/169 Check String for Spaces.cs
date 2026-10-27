//Create a function that returns true if a string contains any spaces.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public static class Program169
    {
        public static bool HasSpaces(string str)
        {
            return str.Contains(' ');
        }
    }
    public class BenchmarkProgram169
    {
        [Benchmark]
        [Arguments("Foo")]
        [Arguments("Foo bar")]
        [Arguments("Foo ")]
        [Arguments(" Foo")]
        [Arguments(" ")]
        [Arguments("")]
        [Arguments(",./;'[]-=")]
        public bool HasSpaces(string str) => Program169.HasSpaces(str);
    }
}
