//Create a function that takes a number n and returns its length.
using System;
namespace Challenges
{
    public class Program59
    {
        public static int Length(int n)
        {
            int count = 0;
            do
            {
                count++;
                n /= 10; // Divide n by 10 to remove the last digit
            } while (n != 0);

            return count;
        }
    }
}