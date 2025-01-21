//Given two strings, firstName and lastName, return a single string in the format "last, first".
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program42
    {
        public static string ConcatName(string firstName, string lastName) => lastName + ", " + firstName;
    }
    public class BenchmarkProgram42
    {
        [Benchmark]
        [Arguments("John", "Doe")]
        [Arguments("First", "Last")]
        [Arguments("A", "B")]
        [Arguments(",", ",")]
        public string ConcatName(string firstName, string lastName) => Program42.ConcatName(firstName, lastName);
    }
}