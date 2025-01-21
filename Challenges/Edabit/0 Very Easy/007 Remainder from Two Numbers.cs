/*There is a single operator in C#, capable of providing the remainder of a division operation.
Two numbers are passed as parameters. The first parameter divided by the second parameter will
have a remainder, possibly zero. Return that value.*/
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program7
    {
        public static int Remainder(int x, int y) => x % y;
    }
    public class BenchmarkProgram7
    {
        [Benchmark]
        [Arguments(7, 2)]
        [Arguments(3, 4)]
        [Arguments(-9, 45)]
        [Arguments(5, 5)]
        public int Remainder(int x, int y) => Program7.Remainder(x, y);
    }
}