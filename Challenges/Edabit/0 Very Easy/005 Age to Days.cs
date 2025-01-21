//Create a function that takes the age in years and returns the age in days.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program5
    {
        public static int CalcAge(int age) => age * 365;
    }
    public class BenchmarkProgram5
    {
        [Benchmark]
        [Arguments(10)]
        [Arguments(0)]
        [Arguments(73)]
        public int CalcAge(int age) => Program5.CalcAge(age);
    }
}