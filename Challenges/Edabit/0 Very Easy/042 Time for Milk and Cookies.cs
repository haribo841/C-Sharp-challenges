//Christmas Eve is almost upon us, so naturally we need to prepare some milk and cookies for Santa!
//Create a function that accepts year, month and day as integers and returns true if it's Christmas Eve (December 24th) and false otherwise.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program42
    {
#pragma warning disable IDE0060 // Remove unused parameter
        public static bool TimeForMilkAndCookies(int year, int month, int day) => month == 12 && day == 24;
#pragma warning restore IDE0060 // Remove unused parameter
    }
    public class BenchmarkProgram42
    {
        [Benchmark]
        [Arguments(2013, 12, 24)]
        [Arguments(2013, 0, 23)]
        [Arguments(3000, 12, 24)]
        public bool TimeForMilkAndCookies(int year, int month, int day) => Program42.TimeForMilkAndCookies(year, month, day);
    }
}