//Fix the code in the code tab to pass this challenge (only syntax errors).
using BenchmarkDotNet.Attributes;
using System;
using System.Text;

namespace Challenges
{
    public class Program31
    {
        public static string RemoveNumbers(string str)
        {
            var result = new StringBuilder();

            foreach (var i in str)
            {
#pragma warning disable IDE0078 // Use pattern matching
                if (i < '0' || i > '9')
                {
                    result.Append(i);
                }
#pragma warning restore IDE0078 // Use pattern matching
            }

            return result.ToString();
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