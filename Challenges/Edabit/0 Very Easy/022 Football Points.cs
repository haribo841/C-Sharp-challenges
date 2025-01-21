//Create a function that takes the number of wins,
//draws and losses and calculates the number of points a football team has obtained so far.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program22
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Delete unused parameter", Justification = "No overload of the \"Football Points\" method takes the following number of arguments: 3")]
        public static int FootballPoints(int wins, int draws, int losses) => wins * 3 + draws;
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