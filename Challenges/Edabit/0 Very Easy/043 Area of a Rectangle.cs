//Create a function that calculates the area of a rectangle.
//If the arguments are invalid, your function must return -1.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public class Program43
    {
        public static int Area(int h, int w) => h <= 0 || w <= 0 ? -1 : h * w;
    }
    public class BenchmarkProgram43
    {
        [Benchmark]
        [Arguments(5, 3)]
        [Arguments(8, 5)]
        [Arguments(5, 4)]
        [Arguments(2, 3)]
        [Arguments(10000, 10000)]
        [Arguments(-2, -5)]
        [Arguments(0, 3)]
        [Arguments(5, -3)]
        [Arguments(0, 1)]
        [Arguments(-1, 0)]
        public int Area(int h, int w) => Program43.Area(h, w);
    }
}