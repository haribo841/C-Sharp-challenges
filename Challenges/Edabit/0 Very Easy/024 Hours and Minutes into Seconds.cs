//Write a function that takes two integers (hours, minutes), converts them to seconds, and adds them.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program24
    {
        public static int Convert(int hours, int minutes) => (hours * 60 + minutes) * 60;
    }
    public class BenchmarkProgram24
    {
        [Benchmark]
        [Arguments(1, 0)]
        [Arguments(1, 3)]
        [Arguments(0, 30)]
        public int Convert(int hours, int minutes) => Program24.Convert(hours, minutes);
    }
}