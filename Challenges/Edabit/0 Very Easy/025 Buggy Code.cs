//Emmy has written a function that returns a greeting to users.
//However, she's in love with Mubashir, and would like to greet him slightly differently.
//She added a special case in her function, but she made a mistake.
//Can you help her?
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program25
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "Intentional")]
        public static string Greeting(string name)
        {
            if (name == "Mubashir")
            {
                return "Hello, my Love!";
            }
            return "Hello, " + name + "!";
        }
    }
    public class BenchmarkProgram25
    {
        [Benchmark]
        [Arguments("Matt")]
        [Arguments("Helen")]
        [Arguments("Mubashir")]
        public string Greeting(string name) => Program25.Greeting(name);
    }
}