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
            int l = 0;
            int u=0;
            // Create an array of chars from string.
            char[] charArray = str.ToCharArray();
            foreach (char c in charArray)
            {
                if (c is ' ' or '.' or '!') continue;
                else if (char.IsUpper(c))
                {
                    u++;
                    continue;
                }
                l++;
                continue;
            }
            return u > 0 ? (l > 0 ? "mixed" : "upper") : "lower"; ;
        }
    }
}
