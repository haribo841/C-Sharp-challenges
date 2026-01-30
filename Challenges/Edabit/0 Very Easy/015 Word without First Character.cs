//Create a function that takes a word and returns the new word without including the first character.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program15
    {
        public static string NewWord(string str) => new string(str.Skip(1).ToArray());
    }
    public class BenchmarkProgram15
    {
        [Benchmark]
        [Arguments("pokhara")]
        [Arguments("biratnagar")]
        [Arguments("nepal")]
        [Arguments("damak")]
        [Arguments("itahari")]
        [Arguments("rasuwa")]
        [Arguments("rolpa")]
        public string NewWord(string str) => Program15.NewWord(str);
    }
}