//Create a function which returns "upper" if all the letters in a word are uppercase, "lower" if lowercase and "mixed" for any mix of the two.
using System;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenges.Edabit
{
    public static class Program92
    {
        public static string GetCase(string str)
        {
            bool hasUppercase = false;
            bool hasLowercase = false;
            foreach (char c in str.Where(char.IsLetter))
            {
                if (char.IsUpper(c)) hasUppercase = true;
                else hasLowercase = true;
            }
            if (hasUppercase && hasLowercase)
                return "mixed";
            return hasUppercase ? "upper" : "lower";
        }
    }
}
