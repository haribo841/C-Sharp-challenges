//Create a function that returns true if a string is empty and false otherwise.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program50
    {
        public static bool IsEmpty(string str) => string.IsNullOrEmpty(str);
    }
    public class BenchmarkProgram50
    {
        [Benchmark]
        [Arguments("")]
        [Arguments(" ")]
        [Arguments("            ")]
        [Arguments("38215")]
        [Arguments("afjabsdf")]
        [Arguments("!?@&")]
        public bool IsEmpty(string str) => Program50.IsEmpty(str);
    }
}