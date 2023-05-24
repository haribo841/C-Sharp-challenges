//Create a function that takes a string and returns the word count.
//The string will be a sentence.
using System;
using System.Text;
namespace Challenges
{
    public class Program96
    {
        public static int CountWords(string str)
        {
            int i = 0;
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    i++;
                }
            }
            return ++i;
        }
    }
}
