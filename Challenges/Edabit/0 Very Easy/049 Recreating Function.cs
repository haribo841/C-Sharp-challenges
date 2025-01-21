//The Math.Abs() function returns the absolute value of a number.
//This means that it returns a number's positive value.
//You can think of it as the distance away from zero.
//Create a function that recreates this functionality.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public class Program49
    {
        public static int Absolute(int num) => (num ^ (num >> 31)) - (num >> 31);
    }
    public class BenchmarkProgram49
    {
        [Benchmark]
        [Arguments(-5)]
        [Arguments(-3)]
        [Arguments(250)]
        [Arguments(0)]
        [Arguments(6)]
        [Arguments(1103)]
        public int Absolute(int num) => Program49.Absolute(num);
    }
}