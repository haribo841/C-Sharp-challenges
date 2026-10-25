//Create a function that takes a string (a random name).
//If the last character of the name is an "n", return true, otherwise return false.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public class Program58
    {
        public static bool IsLastCharacterN(string word) => word[^1] == 'n';
    }
    public class BenchmarkProgram58
    {
        [Benchmark]
        [Arguments("Aiden")]
        [Arguments("Roxy")]
        [Arguments("Bert")]
        [Arguments("Dean")]
        [Arguments("Ian")]
        [Arguments("Brian")]
        [Arguments("Daniel")]
        public bool IsLastCharacterN(string word) => Program58.IsLastCharacterN(word);
    }
}