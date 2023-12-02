//Given an array of numbers, write a function that returns an array that...
//Has all duplicate elements removed.
//Is sorted from least value to greatest value.
using System;
using System.Linq;

namespace Challenges
{
    public class Program158
    {
        public static double[] UniqueSort(double[] arr)
        {
            string s = "";
            foreach (var a in arr)
            {
                string temp = a.ToString() + "";
                if (s.IndexOf(temp) == -1)
                {
                    s += temp + ",";
                }
            }
            string[] st = s.TrimEnd(',').Split(',');
            double[] d = new double[st.Length];
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = double.Parse(st[i]);
            }

            // Sorting the array using bubble sort
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = i + 1; j < d.Length; j++)
                {
                    if (d[j] < d[i])
                    {
                        double temp = d[j];
                        d[j] = d[i];
                        d[i] = temp;
                    }
                }
            }

            // Ensure all unique elements are included
            List<double> resultList = new List<double>(d);
            foreach (var num in arr)
            {
                if (!resultList.Contains(num))
                {
                    resultList.Add(num);
                }
            }

            double[] finalArray = resultList.ToArray();
            Array.Sort(finalArray);

            return finalArray;
        }
    }
}
/*        {
            HashSet<double> set = new HashSet<double>(arr);
            double[] uniqueArray = set.ToArray();
            Array.Sort(uniqueArray);
            return uniqueArray;
        }
*
        {
            // Create a HashSet to store unique elements
            HashSet<double> uniqueSet = new HashSet<double>();

            // Add elements to HashSet (automatically removes duplicates)
            foreach (var num in arr)
            {
                uniqueSet.Add(num);
            }

            // Convert HashSet back to array and sort
            double[] uniqueSortedArray = uniqueSet.ToArray();
            Array.Sort(uniqueSortedArray);

            return uniqueSortedArray;
        }
 *
*        {
            Dictionary<double, int> uniqueDict = new();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!uniqueDict.ContainsKey(arr[i]))
                {
                    uniqueDict[arr[i]] = i; // Storing index for reference (optional)
                }
            }

            double[] uniqueArray = uniqueDict.Keys.OrderBy(key => key).ToArray();
            return uniqueArray;
        }
*
*{
    var uniqueElements = arr.Distinct().ToArray();
    Array.Sort(uniqueElements);
    return uniqueElements;
}
*
*{
    var uniqueElements = arr.Distinct().OrderBy(num => num).ToArray();
    return uniqueElements;
}
*
 *         {
            object[] UniqueSort1(double[] arr)
            {
                // Create a new dictionary of strings, with string keys.
                Dictionary<object, int> openWith = new();
                // Add some elements to the dictionary. There are no
                // duplicate keys, but some of the values are duplicates.
                for (int i = 0; i < arr.Length; i++)
                {
                    // The Add method throws an exception if the new key is
                    // already in the dictionary.
                    try
                    {
                        openWith.Add(arr[i], i);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("An element with Key = " + arr[i] + " already exists.");
                    }
                }
                return openWith.Keys.Order().ToArray();
            }
            object [] arr2  = UniqueSort1(arr);
            double[] result = new double[arr2.Length];
            for (int i = 0;i < arr2.Length;i++)
            {
                result[i] = (double)arr2[i];
            }
            return result;
        }
 */