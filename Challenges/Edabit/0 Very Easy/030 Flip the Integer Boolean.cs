//An int boolean is the same as a normal boolean, just 1 = true and 0 = false.
//Make a function that returns an int boolean opposite of an int boolean given (flip the int boolean).
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program30
    {
        public static int FlipIntBool(int ib) => 1^ib;
    }
    public class BenchmarkProgram30
    {
        [Benchmark]
        [Arguments(1)]
        [Arguments(0)]
        public int FlipIntBool(int ib) => Program30.FlipIntBool(ib);
    }
}