//The Math.Abs() function returns the absolute value of a number.
//This means that it returns a number's positive value.
//You can think of it as the distance away from zero.
//Create a function that recreates this functionality.
using System;
namespace Challenges
{
    public class Program49
    {
        public static int Absolute(int num) => num < 0 ? num * -1 : num;
    }
}