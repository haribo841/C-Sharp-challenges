//Create a function that takes an array of items, removes all duplicate items and returns a new array in the same sequential order as the old array (minus duplicates).
using System;

namespace Challenges
{
    public class Program149
    {
        public static object[] RemoveDups(object[] str)
        {
            // Create a new dictionary of strings, with string keys.
            Dictionary< object, int> openWith =new();

            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            for (int i = 0; i < str.Length; i++) 
            {
                // The Add method throws an exception if the new key is
                // already in the dictionary.
                try
                {
                    openWith.Add( str[i], i);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("An element with Key = "+str[i]+" already exists.");
                }
            }
            return openWith.Keys.ToArray();
        }
    }
}