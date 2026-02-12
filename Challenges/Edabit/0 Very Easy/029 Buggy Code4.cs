//Emmy has written a function that returns a greeting to users.
//However, she's in love with Mubashir, and would like to greet him slightly differently.
//She added a special case in her function, but she made a mistake.
//Can you help her?
using BenchmarkDotNet.Attributes;
using System;
using System.Xml.Linq;

namespace Challenges
{
    public class Program29
    {
        public static string Greeting(string name)
        {
#pragma warning disable IDE0046 // Convert to conditional expression
            if (name == "Mubashir")
            {
                return "Hello, my Love!";
            }
#pragma warning restore IDE0046 // Convert to conditional expression
            return "Hello, " + name + "!";
        }
    }
    public class BenchmarkProgram29
    {
        [Benchmark]
        [Arguments("Matt")]
        [Arguments("Helen")]
        [Arguments("Mubashir")]
        public string Greeting(string name) => Program29.Greeting(name);
    }
}