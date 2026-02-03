//Fix the code in the code tab to pass this challenge (only syntax errors).
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program24b
    {
        public static int Cubes(int a)
        {
            return a * a * a;
        }
    }
    public class BenchmarkProgram24b
    {
        [Benchmark]
        [Arguments(2, 8)]
        [Arguments(3, 27)]
        [Arguments(4, 64)]
        [Arguments(5, 125)]
        [Arguments(10, 1000)]
        public int Cubes(int a) => Program24b.Cubes(a);
    }
}