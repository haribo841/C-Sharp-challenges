//Given two integers, a and b, return true if a can be divided evenly by b. Return false otherwise.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program31
    {
        public static bool DividesEvenly(int a, int b) => a % b == 0;
    }
    public class BenchmarkProgram31
    {
        [Benchmark]
        [Arguments(98, 7)]
        [Arguments(87, 49)]
        [Arguments(34, 14)]
        [Arguments(78, 6)]
        [Arguments(30, 4)]
        [Arguments(87, 73)]
        [Arguments(74, 7)]
        [Arguments(87, 29)]
        [Arguments(48, 24)]
        [Arguments(99, 20)]
        [Arguments(98, 49)]
        [Arguments(100, 6)]
        [Arguments(64, 4)]
        [Arguments(70, 35)]
        [Arguments(38, 38)]
        [Arguments(29, 3)]
        [Arguments(20, 8)]
        [Arguments(66, 50)]
        [Arguments(95, 1)]
        [Arguments(58, 2)]
        public bool DividesEvenly(int a, int b) => Program31.DividesEvenly(a, b);
    }
}