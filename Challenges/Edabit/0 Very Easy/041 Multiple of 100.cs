//Create a function that takes an integer and returns true if it's divisible by 100, otherwise return false.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program41
    {
        public static bool Divisible(int number) => number % 100 == 0;
    }
    public class BenchmarkProgram41
    {
        [Benchmark]
        [Arguments(1)]
        [Arguments(100)]
        [Arguments(1000)]
        [Arguments(111000)]
        [Arguments(-1)]
        [Arguments(0)]
        [Arguments(-100)]
        public bool Divisible(int number) => Program41.Divisible(number);
    }
}