//Write two functions:
//1. toInt() : A function to convert a string to an integer.
//2. toStr() : A function to convert an integer to a string.
using System;
namespace Challenges
{
    public class Program64
    {
        public static int ToInt(string str) => int.Parse(str);
        public static string ToStr(int num) => num.ToString();
    }
}
