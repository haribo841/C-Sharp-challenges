//Write a function that returns the string "something" joined with a space " " and the given argument a.
using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Runtime.Utilities;
using System;

namespace Challenges
{
    public class Program11
    {
        public static string GiveMeSomething(string a) => "something " + a;
    }
    public class BenchmarkProgram11
    {
        [Benchmark]
        [Arguments("a")]
        [Arguments("is cooking")]
        [Arguments(" is cooking")]
        public string GiveMeSomething(string a) => Program11.GiveMeSomething(a);
    }
}