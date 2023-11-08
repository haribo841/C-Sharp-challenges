//Given an array of numbers, write a function that returns an array that...
//Has all duplicate elements removed.
//Is sorted from least value to greatest value.
using System;
using System.Linq;

namespace Challenges
{
    public class Program158
    {
        public static double[] UniqueSort(double[] arr)
        {
            static object[] UniqueSort1(double[] arr)
            {
                // Create a new dictionary of strings, with string keys.
                Dictionary<object, int> openWith = new();
                // Add some elements to the dictionary. There are no
                // duplicate keys, but some of the values are duplicates.
                for (int i = 0; i < arr.Length; i++)
                {
                    // The Add method throws an exception if the new key is
                    // already in the dictionary.
                    try
                    {
                        openWith.Add(arr[i], i);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("An element with Key = " + arr[i] + " already exists.");
                    }
                }
                return openWith.Keys.Order().ToArray();
            }
            object [] arr2  = UniqueSort1(arr);
            double[] result = new double[arr2.Length];
            for (int i = 0;i < arr2.Length;i++)
            {
                result[i] = (double)arr2[i];
            }
            return result;
        }
    }
}