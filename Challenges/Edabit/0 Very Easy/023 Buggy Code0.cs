//Create a function that takes the number of wins,
//draws and losses and calculates the number of points a football team has obtained so far.
using BenchmarkDotNet.Attributes;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenges
{
    public class Program23
    {
        public static string Has_bugs(bool buggy_code)
        {
#pragma warning disable IDE0046 // Convert to conditional expression
            if (buggy_code)
            {
                return "sad days";

            }
            else
            {
                return "it's a good day";

            }
#pragma warning restore IDE0046 // Convert to conditional expression
        }
    }
    public class BenchmarkProgram23
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