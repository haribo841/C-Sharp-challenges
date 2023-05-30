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
            string[] words = str.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
