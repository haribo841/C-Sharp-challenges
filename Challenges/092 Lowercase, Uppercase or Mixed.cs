//Create a function which returns "upper" if all the letters in a word are uppercase, "lower" if lowercase and "mixed" for any mix of the two.
using System;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenges
{
    public class Program92
    {
        public static string GetCase(string str)
        {
            int uppercaseCount = str.Count(char.IsUpper);
            int lowercaseCount = str.Count(char.IsLower);
            return uppercaseCount > 0 && lowercaseCount > 0 ? "mixed" : uppercaseCount > 0 ? "upper" : "lower";
        }
    }
}
