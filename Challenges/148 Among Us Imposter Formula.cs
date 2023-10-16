//Create a function that calculates the chance of being an imposter.
//The formula for the chances of being an imposter is 100 × (i / p)
//where i is the imposter count and p is the player count.
//Make sure to round the value to the nearest integer and return the value as a percentage.
using System;

namespace Challenges
{
    public class Program148
    {
        public static string ImposterFormula(int i, int p)
        {
            return $"{Math.Round(100 * ((double)i / p))}%";
        }
    }
}