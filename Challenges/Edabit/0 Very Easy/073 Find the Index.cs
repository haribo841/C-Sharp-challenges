//Create a function that finds the index of a given item.
using System;
namespace Challenges
{
    public class Program73
    {
        public static int Search(int[] arr, int item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    return i;
                }
            }

            return -1; // Item not found
        }
    }
}
/*         {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    return i;
                }
            }

            return -1; // Item not found
        }


{
    Dictionary<int, int> indexDict = new Dictionary<int, int>();

    for (int i = 0; i < arr.Length; i++)
    {
        if (!indexDict.ContainsKey(arr[i]))
        {
            indexDict[arr[i]] = i;
        }
    }

    if (indexDict.TryGetValue(item, out int index))
    {
        return index;
    }

    return -1; // Item not found
}
*/