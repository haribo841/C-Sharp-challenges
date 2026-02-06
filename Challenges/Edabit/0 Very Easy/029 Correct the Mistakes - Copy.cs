//Look at the examples below to get an idea of what the function should do.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program29b
    {
        public static int Squaed(int b)
        {
            return b * b;
        }
    }
    public class BenchmarkProgram29b
    {
        [Benchmark]
        [Arguments(10)]
        [Arguments(69)]
        [Arguments(666)]
        [Arguments(-21)]
        [Arguments(21)]
        public int Squaed(int b) => Program29b.Squaed(b);
    }
}