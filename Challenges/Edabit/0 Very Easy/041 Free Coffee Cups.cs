//For each of the 6 coffee cups I buy, I get a 7th cup free. In total, I get 7 cups.
//Create a function that takes n cups bought and return the total number of cups I would get.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program41
    {
        public static int TotalCups(int n) => n / 6 + n;
    }
    public class BenchmarkProgram41
    {
        [Benchmark]
        [Arguments(6)]
        [Arguments(3)]
        [Arguments(7)]
        [Arguments(12)]
        [Arguments(213)]
        [Arguments(16)]
        public int TotalCups(int n) => Program41.TotalCups(n);
    }
}