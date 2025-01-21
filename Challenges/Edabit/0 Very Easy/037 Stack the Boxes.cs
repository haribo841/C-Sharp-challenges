//Here's an image of four models. Some of the cubes are hidden behind other cubes.
//Model one consists of one cube. Model two consists of four cubes, and so on...
//Write a function that takes a number n and returns the number of stacked boxes in a model n levels high, visible and invisible.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program37
    {
        public static int StackBoxes(int n) => n * n;
    }
    public class BenchmarkProgram37
    {
        [Benchmark]
        [Arguments(1)]
        [Arguments(2)]
        [Arguments(0)]
        [Arguments(5)]
        [Arguments(27)]
        [Arguments(196)]
        [Arguments(512)]
        public int StackBoxes(int n) => Program37.StackBoxes(n);
    }
}