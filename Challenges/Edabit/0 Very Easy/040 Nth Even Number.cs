//Create a function that takes a number n and returns the nth even number beginning with 0 as the first.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program40
    {
        public static int NthEven(int n) => (n<<1) - 2;
    }
    public class BenchmarkProgram40
    {
        [Benchmark]
        [Arguments(1)]
        [Arguments(2)]
        [Arguments(3)]
        [Arguments(100)]
        [Arguments(1298734)]
        public int NthEven(int n) => Program40.NthEven(n);
    }
}