//Create a function which returns the number of true values there are in an array.
using System;
using System.Linq;
using System.Text;
namespace Challenges
{
    public class Program89
    {
        public static int CountTrue(bool[] arr)=>arr.AsParallel().Count(value => value);
    }
}
/* {
    int count = 0;
    foreach (bool value in arr)
    {
        if (value)
        {
            count++;
        }
    }
    return count;
} */