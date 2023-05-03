//Create a function that takes an array of values and returns the first and last values in a new array.
using System;
using System.Text;
namespace Challenges
{
    public class Program82
    {
        public static object[] FirstLast(object[] values)
        {
            object[] result = new object[2];
            result[0] = values[0];
            result[1] = values[values.Length - 1];
            return result;
        }
    }
}