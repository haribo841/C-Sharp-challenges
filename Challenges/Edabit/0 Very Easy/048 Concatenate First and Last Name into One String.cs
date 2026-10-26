//Given two strings, firstName and lastName, return a single string in the format "last, first".
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace Challenges
{
    public static class Program48
    {
        public static string ConcatName(string firstName, string lastName) => string.Concat(lastName, ", ", firstName);
    }
    public class BenchmarkProgram48
    {
        [Benchmark]
        [Arguments("John", "Doe")]
        [Arguments("First", "Last")]
        [Arguments("A", "B")]
        [Arguments(",", ",")]
        public string ConcatName(string firstName, string lastName) => Program48.ConcatName(firstName, lastName);
    }
}
