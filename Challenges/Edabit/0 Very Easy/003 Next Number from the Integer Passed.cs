//Create a function that takes a number as an argument, increments the number by +1 and returns the result.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program3
    {
        public static int Addition(int num) => num + 1;
    }
    public class BenchmarkProgram3
    {
        [Benchmark]
        [Arguments(2)]
        [Arguments(-9)]
        [Arguments(0)]
        [Arguments(100)]
        [Arguments(999)]
        [Arguments(73)]
        public int Addition(int num) => Program3.Addition(num);
    }
}