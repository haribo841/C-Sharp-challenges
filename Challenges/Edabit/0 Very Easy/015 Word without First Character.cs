//Create a function that takes a word and returns the new word without including the first character.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program15
    {
        public static string NewWord(string str) => str[1..];
    }
    [MemoryDiagnoser]
    public class BenchmarkProgram15
    {
        [Params("pokhara", "biratnagar", "nepal", "damak", "itahari", "rasuwa", "rolpa")]
        public string Word = null!;
        [Benchmark]
        public string NewWord_Range() => Program15.NewWord(Word);
    }
}