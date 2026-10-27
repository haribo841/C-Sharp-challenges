//Create a function that takes a number as an argument and returns "even" for even numbers and"odd" for odd numbers.
using Benchmark;
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public static class Program56
    {
        public static string IsEvenOrOdd(int num) => num % 2 == 0 ? "even" : "odd";
    }
    public class BenchmarkProgram56
    {
        [Benchmark]
        [Arguments(3)]
        [Arguments(0)]
        [Arguments(7)]
        [Arguments(12)]
        [Arguments(6474)]
        [Arguments(563)]
        [Arguments(3)]
        [Arguments(301)]
        [Arguments(-3)]
        [Arguments(-0)]
        [Arguments(-7)]
        [Arguments(-12)]
        [Arguments(-563)]
        [Arguments(-6474)]
        [Arguments(-3)]
        [Arguments(-301)]
        public string IsEvenOrOdd(int num) => Program56.IsEvenOrOdd(num);
    }
}
