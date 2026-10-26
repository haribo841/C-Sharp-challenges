//Write a function that returns the length of a string.
//Make your function recursive.
using BenchmarkDotNet.Attributes;
using System;
using System.Reflection;
namespace Challenges
{
    public static class Program59
    {
        public static int Length(string str)
        {
            if (str == null) return 0;

            int Helper(int index, int acc) => index >= str.Length ? acc : Helper(index + 1, acc + 1);
            return Helper(0, 0);
        }
    }
    public class BenchmarkProgram59
    {
        [Benchmark]
        [Arguments("apple")]
        [Arguments("make")]
        [Arguments("a")]
        [Arguments("")]
        public int Length(string str) => Program59.Length(str);
    }
}
