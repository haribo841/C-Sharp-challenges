//Create a function that takes the number of wins,
//draws and losses and calculates the number of points a football team has obtained so far.
using BenchmarkDotNet.Attributes;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenges
{
    public class Program25
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
    public class BenchmarkProgram25
    {
        [Benchmark]
        [Arguments(true)]
        [Arguments(false)]
        public string Has_bugs(bool buggy_code) => Program25.Has_bugs(buggy_code);
    }
}