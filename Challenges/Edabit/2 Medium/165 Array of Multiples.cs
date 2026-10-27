//Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num until the array length reaches length.
using System;

namespace Challenges
{
    public static class Program165
    {
        public static int[] ArrayOfMultiples(int num, int length)
        {
            List<int> list = new List<int>(length);
            for (int i = 1; i <= length; i++)
            {
                list.Add(num*i);
            }
            return list.ToArray();
        }
    }
}
