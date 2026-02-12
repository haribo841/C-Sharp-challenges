//Fix the code in the code tab to pass this challenge (only syntax errors).
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program27
    {
        public static int Maxnum(int n1, int n2)
        {
#pragma warning disable IDE0046 // Convert to conditional expression
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
#pragma warning restore IDE0046 // Convert to conditional expression
        }
    }
    public class BenchmarkProgram27b
    {
        [Benchmark]
        [Arguments(3, 7)]
        [Arguments(-1, 0)]
        [Arguments(1000, 400)]
        [Arguments(-3, -9)]
        [Arguments(88, 90)]
        public int Maxnum(int n1, int n2) => Program27.Maxnum(n1 ,n2);
    }
}