//Write a function that takes an integer minutes and converts it to seconds.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program2
    {
        public static int Convert(int minutes) => minutes * 60;
    }
    public class BenchmarkProgram2
    {
        [Benchmark]
        [Arguments(6)]
        [Arguments(4)]
        [Arguments(8)]
        [Arguments(60)]
        public int Convert(int minutes) => Program2.Convert(minutes);
    }
}