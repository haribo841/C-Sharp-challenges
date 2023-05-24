//Create a function which returns the number of true values there are in an array.
using System;
using System.Linq;
using System.Text;
namespace Challenges
{
    public class Program89
    {
        public static int CountTrue(bool[] arr)
        {
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    x++;
                }
            }
            return x;
        }
    }
}