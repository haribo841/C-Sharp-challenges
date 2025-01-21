//Write a function that converts hours into seconds.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program13
    {
        public static int HowManySeconds(int hours) => hours * 3600;
    }
    public class BenchmarkProgram13
    {
        [Benchmark]
        [Arguments(2)]
        [Arguments(10)]
        [Arguments(24)]
        [Arguments(36)]
        public int HowManySeconds(int hours) => Program13.HowManySeconds(hours);
    }
}