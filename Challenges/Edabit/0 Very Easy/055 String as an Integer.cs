//Create a function that takes a string and returns it as an integer.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public class Program55
    {
        public static int StringInt(string txt)
        {
            int result = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                // Convert the character to its integer value
                int digit = txt[i] - '0';
                result = result * 10 + digit;
            }
            return result;
        }
    }
    public class BenchmarkProgram55
    {
        [Benchmark]
        [Arguments("6")]
        [Arguments("2")]
        [Arguments("10")]
        [Arguments("666")]
        public int StringInt(string txt) => Program55.StringInt(txt);
    }
}
