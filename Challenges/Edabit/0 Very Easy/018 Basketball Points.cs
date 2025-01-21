//You are counting points for a basketball game,
//given the amount of 3-pointers scored and 2-pointers scored,
//find the final points for the team and return that value
//([2 -pointers scored, 3-pointers scored]).
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program18
    {
        public static int Points(int twoPointers, int threePointers) => twoPointers * 2 + threePointers * 3;
    }
    public class BenchmarkProgram18
    {
        [Benchmark]
        [Arguments(1, 1)]
        [Arguments(1, 2)]
        [Arguments(2, 1)]
        [Arguments(2, 2)]
        [Arguments(69, 420)]
        public int Points(int twoPointers, int threePointers) => Program18.Points(twoPointers, threePointers);
    }
}