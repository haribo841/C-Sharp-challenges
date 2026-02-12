//Create a function that takes the number of wins,
//draws and losses and calculates the number of points a football team has obtained so far.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program22
    {
#pragma warning disable IDE0060 // Remove unused parameter
        public static int FootballPoints(int wins, int draws, int losses) => wins * 3 + draws;
#pragma warning restore IDE0060 // Remove unused parameter
    }
    public class BenchmarkProgram22
    {
        [Benchmark]
        [Arguments(1, 2, 3)]
        [Arguments(5, 5, 5)]
        [Arguments(1, 0, 0)]
        [Arguments(0, 7, 0)]
        [Arguments(0, 0, 15)]
        public int FootballPoints(int wins, int draws, int losses) => Program22.FootballPoints(wins, draws, losses);
    }
}