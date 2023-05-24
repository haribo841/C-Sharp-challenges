//Create a function that takes in a word and determines whether or not it is plural.
//A plural word is one that ends in "s".
using System;
namespace Challenges
{
    public class Program62
    {
        public static bool IsPlural(string word) => word.Substring(word.Length - 1, 1)[0] == 's';
    }
}
