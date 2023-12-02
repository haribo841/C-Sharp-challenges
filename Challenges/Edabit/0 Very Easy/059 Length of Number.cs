//Create a function that takes a number n and returns its length.
using System;
namespace Challenges
{
    public class Program59
    {
        public static int Length(int n)
        {
            if (n == 0)
                return 1;

            // Calculate the number of digits using logarithms
            int numDigits = (int)Math.Floor(Math.Log10(n)) + 1;

            return numDigits;
        }
    }
}
// =>(n == 0)?1:(int)Math.Floor(Math.Log10(n)) + 1;
// => num == 0 ? 1 : (int)Math.Floor(Math.Log10(Math.Abs(num)) + 1);
// => (n == 0) ? 1 : (int)Math.Floor(Math.Log10(Math.Abs(n)) + 1);
