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

            int length = 0;

            while (n >= 10)
            {
                n /= 10;
                length++;
            }

            return length + 1;
        }
    }
}
