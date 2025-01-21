//Create a function which validates whether a bridge is safe to walk on (i.e. has no gaps in it to fall through).
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public class Program51
    {
        public static bool IsSafeBridge(string str)
        {
            foreach (char c in str)
            {
                if (c == ' ') return false;
            }
            return true;
        }
    }
    public class BenchmarkProgram51
    {
        [Benchmark]
        [Arguments("####")]
        [Arguments("## ####")]
        [Arguments("#")]
        [Arguments("# #")]
        public bool IsSafeBridge(string str) => Program51.IsSafeBridge(str);
    }
}