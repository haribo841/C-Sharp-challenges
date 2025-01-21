//Write a function that returns the length of a string.
//Make your function recursive.
using BenchmarkDotNet.Attributes;
using System;
using System.Reflection;
namespace Challenges
{
    public class Program53
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0057:Use range operator", Justification = "Slower")]
        public static int Length(string str) => string.IsNullOrEmpty(str) ? 0 : 1 + Length(str.Substring(1));
    }
    public class BenchmarkProgram53
    {
        [Benchmark]
        [Arguments("apple")]
        [Arguments("make")]
        [Arguments("a")]
        [Arguments("")]
        public int Length(string str) => Program53.Length(str);
    }
}
