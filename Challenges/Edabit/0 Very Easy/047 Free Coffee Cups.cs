//For each of the 6 coffee cups I buy, I get a 7th cup free. In total, I get 7 cups.
//Create a function that takes n cups bought and return the total number of cups I would get.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public static class Program47
    {
        public static int TotalCups(int n) => n + n / 6;
    }
    public class BenchmarkProgram47
    {
        [Benchmark]
        [Arguments(6)]
        [Arguments(3)]
        [Arguments(7)]
        [Arguments(12)]
        [Arguments(213)]
        [Arguments(16)]
        public int TotalCups(int n) => Program47.TotalCups(n);
    }
}
