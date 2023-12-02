//Create a function that takes a two-digit number and determines if it's the largest of two possible digit swaps.
using System;

namespace Challenges
{
    public class Program157
    {
        public static bool LargestSwap(int num)
        {
            int reverse = 0;
            int originalNum = num;

            while (num != 0)
            {
                int rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }

            return originalNum >= reverse;
        }
    }
}
/*
 *         {
            string a= num.ToString();
            if (a[0] == a[1]) return true;
            else if (a[0] < a[1]) return false;
            return true;
        }
*
*        {
            int firstDigit = num / 10;  // Extracting the tens place digit
            int secondDigit = num % 10; // Extracting the ones place digit

            int swapped = secondDigit * 10 + firstDigit; // Creating the swapped number

            return num >= swapped; // Checking if the original number is greater than or equal to the swapped number
        }
 */