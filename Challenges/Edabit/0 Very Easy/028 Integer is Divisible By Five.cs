//Create a function that returns true if an integer is evenly divisible by 5, and false otherwise.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program28
    {
        public static bool DivisibleByFive(int n) => n % 5 == 0;
    }
    public class BenchmarkProgram28
    {
        [Benchmark]
        [Arguments(7)]
        [Arguments(5)]
        [Arguments(15)]
        [Arguments(33)]
        [Arguments(-18)]
        [Arguments(999)]
        [Arguments(2)]
        public bool DivisibleByFive(int n) => Program28.DivisibleByFive(n);
    }
}