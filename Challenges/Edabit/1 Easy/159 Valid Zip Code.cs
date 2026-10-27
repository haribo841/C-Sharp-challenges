//Create a function that takes two integers and checks if they are equal.
using System;

namespace Challenges
{
    public static class Program159
    {
        public static bool IsValid(string zip)
        {
            return zip.Length == 5 && zip.All(char.IsDigit);
        }
    }
}
