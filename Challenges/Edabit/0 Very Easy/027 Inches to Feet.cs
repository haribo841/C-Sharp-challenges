//Create a function that accepts a measurement value in inches and returns the equivalent of the measurement value in feet.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program27
    {
        public static int InchesToFeet(int inches) => inches < 12 ? 0 : inches / 12;
    }
    public class BenchmarkProgram27
    {
        [Benchmark]
        [Arguments(12)]
        [Arguments(360)]
        [Arguments(3612)]
        [Arguments(324)]
        [Arguments(3012)]
        [Arguments(11)]
        public bool DivisibleByFive(int n) => Program28b.DivisibleByFive(n);
    }
}