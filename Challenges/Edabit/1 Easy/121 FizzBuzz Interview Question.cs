//Create a function that takes a number as an argument and returns "Fizz", "Buzz" or "FizzBuzz".
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenges
{
    public static class Program121
    {
        public static string FizzBuzz(int n)
        {
            if (n % 15 == 0)
                return "FizzBuzz";
            if (n % 5 == 0)
                return "Buzz";
            if (n % 3 == 0)
                return "Fizz";
            return n.ToString();
        }
    }
}
