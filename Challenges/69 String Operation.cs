//Create a function that takes two numbers and a mathematical operator and returns the result.
using System;
namespace Challenges
{
    public class Program69
    {
        public static int Calculate(int num1, int num2, string operation) => (operation) switch
        {
            string n when n == "+" => num1 + num2,
            string n when n == "-" => num1 - num2,
            string n when n == "*" => num1 * num2,
            string n when n == "%" => num1 % num2,
            string n when n == "/" => num1 / num2,
            _ => 0     
        };
    }
}
