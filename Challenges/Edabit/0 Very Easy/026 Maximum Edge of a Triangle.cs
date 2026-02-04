//Create a function that finds the maximum range of a triangle's third edge, where the side lengths are all integers.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program26b
    {
        public static int NextEdge(int side1, int side2) => --side1 + side2;
    }
    public class BenchmarkProgram26b
    {
        [Benchmark]
        [Arguments(5, 4)]
        [Arguments(8, 3)]
        [Arguments(7, 9)]
        [Arguments(10, 4)]
        [Arguments(7, 2)]
        public int NextEdge(int side1, int side2) => Program26b.NextEdge(side1, side2);
    }
}