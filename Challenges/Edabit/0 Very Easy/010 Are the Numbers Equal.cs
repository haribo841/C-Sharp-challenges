//Create a function that takes two integers and checks if they are equal.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program10
    {
        public static bool IsEqual(int num1, int num2) => num1 == num2;
    }
    public class BenchmarkProgram10
    {
        [Benchmark]
        [Arguments(2, 2)]
        [Arguments(88, 88)]
        [Arguments(36, 35)]
        [Arguments(1, 1)]
        [Arguments(5, 6)]
        public bool IsEqual(int num1, int num2) => Program10.IsEqual(num1, num2);
    }
}