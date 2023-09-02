//Create a function that takes an array of strings and returns the words that are exactly four letters.
using System;

namespace Challenges
{
    public class Program139
    {
        public static string[] IsFourLetters(string[] arr)
        {
            int counter = 0;
            int counter2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 4) counter++;
            }
            string[] result = new string[counter];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 4)
                {
                    result[counter2] = arr[i];
                    counter2++;
                }
            }
            return result;
        }
    }
}