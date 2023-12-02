//Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num until the array length reaches length.
using System;

namespace Challenges
{
    public class Program165
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
/*
 *     {
        int[] result = new int[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = num * (i + 1);
        }
        return result;
    }
*
{
        return Enumerable.Range(1, length).Select(x => x * num).ToArray();
    }
*
    {
        return Enumerable.Repeat(num, length).Select((x, index) => x * (index + 1)).ToArray();
    }
 */