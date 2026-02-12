//Fix the code in the code tab to pass this challenge (only syntax errors).
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program26
    {
        public static int Cubes(int a)
        {
            return a * a * a;
        }
    }
    public class BenchmarkProgram26
    {
        [Benchmark]
        [Arguments(2)]
        [Arguments(3)]
        [Arguments(4)]
        [Arguments(5)]
        [Arguments(10)]
        public int Cubes(int a) => Program26.Cubes(a);
    }
}