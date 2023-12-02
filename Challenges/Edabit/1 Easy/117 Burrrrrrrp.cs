//Create a function that returns the string "Burp" with the amount of "r's" determined by the input parameters of the function.
using System;
namespace Challenges
{
    public class Program117
    {
        public static string LongBurp(int b) => "Bu" + new string('r', b) + "p";
    }
}