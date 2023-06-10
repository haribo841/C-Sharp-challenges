//Create a function that takes a number as an argument and returns "Fizz", "Buzz" or "FizzBuzz".
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenges
{
    public class Program121
    {
        public static string FizzBuzz(int n)
        {
            if (n % 3 == 0 && n % 5 == 0) return "FizzBuzz";
            else if (n % 5 == 0) return "Buzz";
            else if (n % 3 == 0) return "Fizz";
            else return n.ToString();
        }
    }
}