//Fix the code in the code tab to pass this challenge (only syntax errors).
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program32
    {
        public static (int, int) Swap(int a, int b)
        {
            return (b, a);
        }
    }
    public class BenchmarkProgram32
    {
        [Benchmark]
        [Arguments(100, 200)]
        [Arguments(44, 33)]
        [Arguments(21, 12)]
        [Arguments(10, 20)]
        public (int, int) Swap(int a, int b) => Program32.Swap(a, b);
    }
}