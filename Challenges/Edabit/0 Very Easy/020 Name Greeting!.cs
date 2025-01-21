//Create a function that takes a name and returns a greeting in the form of a string.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program20
    {
        public static string HelloName(string name) => $"Hello {name}!";
    }
    public class BenchmarkProgram20
    {
        [Benchmark]
        [Arguments("Gerald")]
        [Arguments("Fatima")]
        [Arguments("Ed")]
        [Arguments("Tiffany")]
        public string HelloName(string name) => Program20.HelloName(name);
    }
}