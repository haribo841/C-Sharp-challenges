//Look at the examples below to get an idea of what the function should do.
using BenchmarkDotNet.Attributes;
using System;
using System.Xml.Linq;

namespace Challenges
{
    public class Program29
    {
        public static string Greeting(string name)
        {
            if (name == "Mubashir")
            {
                return "Hello, my Love!";
            }
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