//Éowyn has written the function IsOdd() to check if a given number is odd or not.
//Unfortunately, the function does not return the correct result for all the inputs.
//Help her fix the error.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program39
    {
        public static bool IsOdd(int num) => num % 2 != 0;
    }
    public class BenchmarkProgram39
    {
        [Benchmark]
        [Arguments(-5)]
        [Arguments(-50)]
        [Arguments(0)]
        [Arguments(25)]
        [Arguments(-19)]
        [Arguments(12)]
        [Arguments(23)]
        [Arguments(-71)]
        public bool IsOdd(int num) => Program39.IsOdd(num);
    }
}