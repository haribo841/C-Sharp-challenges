//Create a function which returns the number of true values there are in an array.
using System;
using System.Linq;
using System.Text;
namespace Challenges
{
    public static class Program89
    {
        public static int CountTrue(bool[] arr)=>arr.AsParallel().Count(value => value);
    }
}
