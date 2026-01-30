//Create a function that takes a number as its only argument and returns true if it's less than or equal to zero, otherwise return false.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program8
    {
        public static bool LessThanOrEqualToZero(double a) => a <= 0;
    }
    public class BenchmarkProgram8
    {
        [Benchmark]
        [Arguments(5)]
        [Arguments(0)]
        [Arguments(-5)]
        [Arguments(1)]
        [Arguments(2)]
        [Arguments(10000)]
        [Arguments(1)]
        public bool LessThanOrEqualToZero(double a) => Program8.LessThanOrEqualToZero(a);
    }
}