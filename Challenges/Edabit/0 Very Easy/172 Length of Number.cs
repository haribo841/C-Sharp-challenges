//Create a function that takes a number n and returns its length.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public static class Program172
    {
        public static int Length(int n) => Program77.FindDigitAmount(n);
    }
    public class BenchmarkProgram172
    {
        [Benchmark]
        [Arguments(12)]
        [Arguments(6000)]
        [Arguments(314)]
        public int Length(int n) => Program172.Length(n);
    }
}
