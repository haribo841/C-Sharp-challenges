//Given an n-sided regular polygon n, return the total sum of internal angles (in degrees).
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program14
    {
        public static int SumPolygon(int num) => (num - 2) * 180;
    }
    public class BenchmarkProgram14
    {
        [Benchmark]
        [Arguments(21)]
        [Arguments(22)]
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
        [Arguments(16)]
        [Arguments(17)]
        [Arguments(18)]
        [Arguments(19)]
        [Arguments(20)]
        public int SumPolygon(int num) => Program14.SumPolygon(num);
    }
}