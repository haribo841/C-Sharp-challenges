//Create a function that takes three arguments prob, prize, pay and returns true if prob * prize > pay; otherwise return false.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program33
    {
        public static bool ProfitableGamble(double prob, int prize, double pay) => prob * prize > pay;
    }
    public class BenchmarkProgram33
    {
        [Benchmark]
        [Arguments(0.2, 50, 9)]
        [Arguments(0.9, 1, 2)]
        [Arguments(0.9, 3, 2)]
        [Arguments(0.33, 10, 3.30)]
        [Arguments(0, 1000, 0.01)]
        [Arguments(0.1, 1000, 7)]
        [Arguments(0, 0, 0)]
        public bool ProfitableGamble(double prob, int prize, double pay) => Program33.ProfitableGamble(prob, prize, pay);
    }
}