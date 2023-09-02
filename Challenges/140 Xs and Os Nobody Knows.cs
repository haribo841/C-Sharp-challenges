//Create a function that takes a string, checks if it has the same number of x's and o's and returns either true or false.
//Return a boolean value (true or false).
//Return true if the amount of x's and o's are the same.
//Return false if they aren't the same amount.
//The string can contain any character.
//When "x" and "o" are not in the string, return true.
using System;

namespace Challenges
{
    public class Program140
    {
        public static bool XO(string str)
        {
            int xCounter = 0;
            int oCounter = 0;
            foreach (char c in str)
            {
                if (c == 'x' || c == 'X') xCounter++;
                if (c ==  'o' || c == 'O') oCounter++;
            }
            if (xCounter == oCounter || xCounter == 0 && oCounter == 0) return true;
            return false;
        }
    }
}