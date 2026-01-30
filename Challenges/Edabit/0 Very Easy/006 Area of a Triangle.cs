//Write a function that takes the base and height of a triangle and return its area.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program6
    {
        public static int TriArea(int b, int h) => b * h / 2;
    }
    public class BenchmarkProgram6
    {
        [Benchmark]
        [Arguments(3, 2)]
        [Arguments(5, 4)]
        [Arguments(10, 10)]
        [Arguments(0, 60)]
        [Arguments(12, 11)]
        public int TriArea(int b, int h) => Program6.TriArea(b, h);
    }
}