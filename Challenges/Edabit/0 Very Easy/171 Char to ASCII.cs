//Create a function that returns the ASCII value of the passed in character.
using BenchmarkDotNet.Attributes;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Challenges
{
    public class Program171
    {
        public static int CharToASCII(char ch) => ch;
    }
    public class BenchmarkProgram171
    {
        [Benchmark]
        [Arguments('E')]
        [Arguments('d')]
        [Arguments('a')]
        [Arguments('b')]
        [Arguments('i')]
        [Arguments('t')]
        [Arguments('.')]
        [Arguments(' ')]
        [Arguments('1')]
        public int CharToASCII(char ch) => Program171.CharToASCII(ch);
    }
}
