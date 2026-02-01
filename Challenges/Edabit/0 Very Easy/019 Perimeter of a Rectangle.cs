//Create a function that takes length and width and finds the perimeter of a rectangle.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program19
    {
        public static int FindPerimeter(int length, int width) => (length + width)*2;
    }
    public class BenchmarkProgram19
    {
        [Benchmark]
        [Arguments(6, 7)]
        [Arguments(20, 10)]
        [Arguments(2, 9)]
        public int FindPerimeter(int length, int width) => Program18.Points(length, width);
    }
}