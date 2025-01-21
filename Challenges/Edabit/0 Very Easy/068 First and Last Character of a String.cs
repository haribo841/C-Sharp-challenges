//Create a function that takes a string and returns the concatenated first and last character.
using BenchmarkDotNet.Attributes;
using System;
using System.Text;
namespace Challenges
{
    public class Program68
    {
        public static string FirstLast(string str)
        {
            Span<char> buffer = stackalloc char[2]; // Allocate on the stack
            buffer[0] = str[0];
            buffer[1] = str[^1];
            return new string(buffer);
        }
    }
    public class BenchmarkProgram68
    {
        [Benchmark]
        [Arguments("forza")]
        [Arguments("kali")]
        [Arguments("always")]
        [Arguments("love")]
        [Arguments("supernatural")]
        [Arguments("edabit")]
        public string Span(string str) => Program68.FirstLast(str);
    }
}
