//Write a function that takes two numbers and returns if they should be added, subtracted, multiplied or divided to get 24.
//If none of the operations can give 24, return "none".
using System;
using System.Linq.Expressions;

namespace Challenges
{
    public class Program63
    {
        public static string Operation(int num1, int num2) => 24 switch
        {
            int n when n == num1 + num2 => "added",
            int n when n == num1 - num2 => "subtracted",
            int n when n == num1 * num2 => "multiplied",
            int n when n == num1 / num2 => "divided",
            _ => "none"
        };
    }
}
