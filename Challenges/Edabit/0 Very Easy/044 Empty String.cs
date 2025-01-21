//Create a function that returns true if a string is empty and false otherwise.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program44
    {
        public static bool IsEmpty(string str) => string.IsNullOrEmpty(str);
    }
    public class BenchmarkProgram44
    {
        [Benchmark]
        [Arguments("")]
        [Arguments(" ")]
        [Arguments("            ")]
        [Arguments("38215")]
        [Arguments("afjabsdf")]
        [Arguments("!?@&")]
        public bool IsEmpty(string str) => Program44.IsEmpty(str);
    }
}