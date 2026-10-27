//Create a function that takes an array of items, removes all duplicate items and returns a new array in the same sequential order as the old array (minus duplicates).
using System;
using System.Linq;

namespace Challenges
{
    public static class Program149
    {
        public static object[] RemoveDups(object[] str)
        {
            return str.Distinct().ToArray();
        }
    }
}
