//Create a function that takes a number as an argument and returns negative of that number.
//Return negative numbers without any change.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public static class Program53
    {
        public static int ReturnNegative(int n) => n < 0 ? n : -n;
    }
    public class BenchmarkProgram53
    {
        [Benchmark]
        [Arguments(-4)]
        [Arguments(212)]
        [Arguments(-125)]
        [Arguments(932123)]
        public int ReturnNegative(int n) => Program53.ReturnNegative(n);
    }
}
