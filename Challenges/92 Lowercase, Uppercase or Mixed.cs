//Create a function which returns "upper" if all the letters in a word are uppercase, "lower" if lowercase and "mixed" for any mix of the two.
using System;
using System.Linq;
using System.Text;
namespace Challenges
{
    public class Program92
    {
        public static string GetCase(string str)
        {

            // Create an array of chars from string.
            char[] charArray = str.ToCharArray();
            char x;
            bool upper = charArray.All(str => str.IsUpper(x));
            bool lower = charArray.All(str => str.IsLower(x));

           return upper ? "upper" : lower ? "lower" : "mixed";
        }
    }
}
