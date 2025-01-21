//Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program9
    {
        public static bool LessThan100(int a, int b) => a + b < 100;
    }
    public class BenchmarkProgram9
    {
        [Benchmark]
        [Arguments(5, 57)]
        [Arguments(77, 30)]
        [Arguments(0, 59)]
        [Arguments(78, 35)]
        [Arguments(63, 11)]
        [Arguments(37, 99)]
        [Arguments(52, 11)]
        [Arguments(82, 95)]
        [Arguments(17, 44)]
        [Arguments(74, 53)]
        [Arguments(3, 77)]
        [Arguments(25, 80)]
        [Arguments(59, 28)]
        [Arguments(69, 87)]
        [Arguments(10, 45)]
        [Arguments(43, 58)]
        [Arguments(50, 44)]
        [Arguments(74, 89)]
        [Arguments(3, 27)]
        [Arguments(21, 79)]
        public bool LessThan100(int a, int b) => Program9.LessThan100(a, b);
    }
}