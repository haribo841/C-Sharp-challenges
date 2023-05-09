//Create a method that returns the number of arguments it was called with.
using System;
using System.Text;
namespace Challenges
{
    public class Program90
    {
        public static int NumArgs(params object[] p) => p.Length;
    }
}