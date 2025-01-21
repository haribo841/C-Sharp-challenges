//Create a function that takes two numbers as arguments and returns their sum.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program1
    {
        public static int Sum(int a, int b) => a + b;
    }
    public class BenchmarkProgram1
    {
        [Benchmark]
        [Arguments(2, 3)]
        [Arguments(-3, -6)]
        [Arguments(7, 3)]
        public int Sum(int a, int b) => Program1.Sum(a, b);
    }
}