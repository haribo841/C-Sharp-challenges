//Write a function that takes two integers (hours, minutes), converts them to seconds, and adds them.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program24b
    {
        public static int Convert(int hours, int minutes) => (hours * 60 + minutes) * 60;
    }
    public class BenchmarkProgram24b
    {
        [Benchmark]
        [Arguments(1, 0)]
        [Arguments(1, 3)]
        [Arguments(0, 30)]
        public int Convert(int hours, int minutes) => Program24b.Convert(hours, minutes);
    }
}