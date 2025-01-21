//Create a function that reverses a boolean value.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program12
    {
        public static bool Reverse(bool boolean) => !boolean;
    }
    public class BenchmarkProgram12
    {
        [Benchmark]
        [Arguments(false)]
        [Arguments(true)]
        public bool Reverse(bool boolean) => Program12.Reverse(boolean);
    }
}