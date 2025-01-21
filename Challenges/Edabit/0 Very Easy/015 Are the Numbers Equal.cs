//Create a function that returns true when num1 is equal to num2; otherwise return false.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program15
    {
        public static bool IsSameNum(int num1, int num2) => Program10.IsEqual(num1, num2);
    }
    public class BenchmarkProgram15
    {
        [Benchmark]
        [Arguments(4, 8)]
        [Arguments(111, 111)]
        [Arguments(2, 5)]
        [Arguments(0, 6)]
        [Arguments(10, 10)]
        public bool IsSameNum(int num1, int num2) => Program15.IsSameNum(num1, num2);
    }
}