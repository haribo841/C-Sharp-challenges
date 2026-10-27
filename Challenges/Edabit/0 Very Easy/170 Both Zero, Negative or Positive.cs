//Write a function that returns true if both numbers are:
//Smaller than 0, OR ...
//Greater than 0, OR ...
//Exactly 0
//Otherwise, return false.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public static class Program170
    {
        public static bool Both(int n1, int n2) => n1 < 0 && n2 < 0 || n1 == 0 && n2 == 0 || n1 > 0 && n2 > 0;
    }
    public class BenchmarkProgram170
    {
        [Benchmark]
        [Arguments(6, 2)]
        [Arguments(-6, -9)]
        [Arguments(6, -2)]
        [Arguments(0, 0)]
        [Arguments(100, 1)]
        [Arguments(-0, 0)]
        [Arguments(-80, -5000)]
        [Arguments(6, -999)]
        [Arguments(-1, 2)]
        [Arguments(0, 2)]
        public bool Both(int n1, int n2) => Program170.Both(n1, n2);
    }
}
