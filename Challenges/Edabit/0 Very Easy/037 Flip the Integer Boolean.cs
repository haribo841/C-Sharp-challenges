//An int boolean is the same as a normal boolean, just 1 = true and 0 = false.
//Make a function that returns an int boolean opposite of an int boolean given (flip the int boolean).
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public static class Program37
    {
        public static int FlipIntBool(int ib) => 1 ^ ib;
    }
    public class BenchmarkProgram37
    {
        [Benchmark]
        [Arguments(1)]
        [Arguments(0)]
        public int FlipIntBool(int ib) => Program37.FlipIntBool(ib);
    }
}
