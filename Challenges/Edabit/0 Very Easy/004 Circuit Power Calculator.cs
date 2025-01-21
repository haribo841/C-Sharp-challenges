//Create a function that takes voltage and current and returns the calculated power.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program4
    {
        public static int CircuitPower(int voltage, int current) => voltage * current;
    }
    public class BenchmarkProgram4
    {
        [Benchmark]
        [Arguments(110, 3)]
        [Arguments(230, 10)]
        [Arguments(480, 20)]
        public int CircuitPower(int voltage, int current) => Program4.CircuitPower(voltage, current);
    }
}