//Create a function that takes two strings as arguments and return either true or false depending on whether
//the total number of characters in the first string is equal to the total number of characters in the second string.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program45
    {
        public static bool Comp(string str1, string str2) => str1.Length == str2.Length;
    }
    public class BenchmarkProgram45
    {
        [Benchmark]
        [Arguments("AB", "CD")]
        [Arguments("ABC", "DE")]
        [Arguments("hello", "edabit")]
        [Arguments("meow", "woof")]
        [Arguments("jrnvjrnnt", "cvjknfjvmfvnfjn")]
        [Arguments("jkvnjrt", "krnf")]
        [Arguments("Facebook", "Snapchat")]
        public bool Comp(string str1, string str2) => Program45.Comp(str1, str2);
    }
}