//Create a function that will work as the modulus operator % without using the modulus operator.
//The modulus operator is a way to determine the remainder of a division operation.
//Instead of returning the result of the division, the modulo operation returns the whole number remainder.
using System;
namespace Challenges
{
    public class Program65
    {
        public static int Mod(int a, int b) => a - b * (a / b);
    }
}