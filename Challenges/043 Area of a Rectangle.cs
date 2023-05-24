//Create a function that calculates the area of a rectangle.
//If the arguments are invalid, your function must return -1.
using System;
namespace Challenges
{
    public class Program43
    {
        public static int Area(int h, int w) => h <= 0 || w <= 0 ? -1 : h * w;
    }
}