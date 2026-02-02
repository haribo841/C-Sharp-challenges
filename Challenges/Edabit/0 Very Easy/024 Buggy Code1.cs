//Write a function that takes two integers (hours, minutes), converts them to seconds, and adds them.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program24
    {
        public static int Cubes(int a)
        {
            return a * a * a;
        }
    }
    public class BenchmarkProgram24
    {
        [Benchmark]
        [Arguments(2, 8)]
        [Arguments(3, 27)]
        [Arguments(4, 64)]
        [Arguments(5, 125)]
        [Arguments(10, 1000)]
        public int Cubes(int a) => Program24.Cubes(a);
    }
}