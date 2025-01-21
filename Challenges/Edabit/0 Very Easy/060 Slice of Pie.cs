//Create a function that determines whether or not it's possible to split a pie fairly given these three parameters:
//Total number of slices.
//Number of recipients.
//How many slices each person gets.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public class Program60
    {
        public static bool EqualSlices(int total, int people, int each) => total >= people * each;
    }
    public class BenchmarkProgram60
    {
        [Benchmark]
        [Arguments(8, 3, 2)]
        [Arguments(8, 3, 3)]
        [Arguments(24, 12, 2)]
        [Arguments(5, 6, 1)]
        [Arguments(5, 0, 100)]
        [Arguments(15, 2, 7)]
        [Arguments(15, 2, 8)]
        public bool EqualSlices(int total, int people, int each) => Program60.EqualSlices(total, people, each);
    }
}