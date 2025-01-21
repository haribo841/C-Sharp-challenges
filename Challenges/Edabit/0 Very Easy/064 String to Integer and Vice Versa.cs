//Write two functions:
//1. toInt() : A function to convert a string to an integer.
//2. toStr() : A function to convert an integer to a string.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public class Program64
    {
        public static int ToInt(string str) => int.Parse(str);
        public static string ToStr(int num) => num.ToString();
    }
    public class BenchmarkProgram64
    {
        [Benchmark]
        [Arguments("37")]
        [Arguments("113")]
        [Arguments("5")]
        [Arguments("5231")]
        public int ToInt(string str) => Program64.ToInt(str);
        [Benchmark]
        [Arguments(37)]
        [Arguments(113)]
        [Arguments(5)]
        [Arguments(5231)]
        public string ToStr(int num) => Program64.ToStr(num);
    }
}
