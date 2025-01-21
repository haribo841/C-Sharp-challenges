//Given a Rubik's Cube with a side length of n, return the number of individual stickers that are needed to cover the whole cube.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program36
    {
        public static int HowManyStickers(int n) => 6 * n * n;
    }
    public class BenchmarkProgram36
    {
        [Benchmark]
        [Arguments(1)]
        [Arguments(2)]
        [Arguments(3)]
        [Arguments(4)]
        [Arguments(5)]
        [Arguments(6)]
        [Arguments(7)]
        [Arguments(8)]
        [Arguments(9)]
        [Arguments(10)]
        [Arguments(11)]
        [Arguments(12)]
        [Arguments(13)]
        [Arguments(14)]
        [Arguments(15)]
        public int HowManyStickers(int n) => Program36.HowManyStickers(n);
    }
}