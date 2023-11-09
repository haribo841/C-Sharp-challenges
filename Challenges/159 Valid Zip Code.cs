//Create a function that takes two integers and checks if they are equal.
using System;

namespace Challenges
{
    public class Program159
    {
        public static bool IsValid(string zip) => zip.Length==5?int.TryParse(zip, out _):false;
    }
}