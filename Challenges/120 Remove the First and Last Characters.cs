//Create a function that removes the first and last characters from a string.
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Challenges
{
    public class Program120
    {
        public static string RemoveFirstLast(string str)
        {
            if (str.Length > 2)
            {
                string modifiedText = str.Remove(0, 1);
                string modifiedText2 = modifiedText.Remove(modifiedText.Length - 1, 1);
                return modifiedText2;
            }
            return str;
        }
    }
}