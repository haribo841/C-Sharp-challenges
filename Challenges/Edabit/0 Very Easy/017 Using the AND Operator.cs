//Consider a && b:
//a is checked if it is true or false.
//If a is false, false is returned.
//b is checked if it is true or false.
//If b is false, false is returned.
//Otherwise, true is returned (as both a and b are therefore true ).
//Rembember that the default value for bool is false. (eg. var c = new bool(); c is false.)
//The && operator will only return true for true && true.
//Make a function using the && operator.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program17
    {
        public static bool And(bool x, bool y) => x && y;
    }
    public class BenchmarkProgram17
    {
        [Benchmark]
        [Arguments(true, true)]
        [Arguments(true, false)]
        [Arguments(false, true)]
        [Arguments(false, false)]
        public bool And(bool x, bool y) => Program17.And(x, y);
    }
}