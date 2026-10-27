//Fix the code in the code tab to pass this challenge (only syntax errors).
using BenchmarkDotNet.Attributes;
using System;
using System.Text;

namespace Challenges
{
    public static class Program31
    {
        public static string RemoveNumbers(string str)
        {
            return new string(str.Where(character => character is < '0' or > '9').ToArray());
        }
    }
    public class BenchmarkProgram31
    {
        [Benchmark]
        [Arguments("mubashir1")]
        [Arguments("12ma23tt")]
        [Arguments("e1d2a3b4i5t6")]
        [Arguments("pakistan007")]
        [Arguments("ai4653rf53or4235ce")]
        public string RemoveNumbers(string str) => Program31.RemoveNumbers(str);
    }
}
