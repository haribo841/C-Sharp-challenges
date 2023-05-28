//Create a function that takes a string and returns the concatenated first and last character.
using System;
namespace Challenges
{
    public class Program68
    {
        public static string FirstLast(string str) => str[0].ToString() + str[^1];
    }
}
