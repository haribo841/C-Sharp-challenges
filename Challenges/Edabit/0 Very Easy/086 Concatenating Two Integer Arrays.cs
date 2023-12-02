//Create a function to concatenate two integer arrays.
using System;
using System.Text;
namespace Challenges
{
    public class Program86
    {
        public static int[] ConcatArrays(int[] arr1, int[] arr2)// => arr1.Concat(arr2).ToArray(); slower
        {
            {
                int[] result = new int[arr1.Length + arr2.Length];
                Array.Copy(arr1, result, arr1.Length);
                Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
                return result;
            }
        }
    }
}
//Naive Approach (Copying Elements):
/* {
        int[] result = new int[array1.Length + array2.Length];

        // Copy elements from array1 to result
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i];
        }

        // Copy elements from array2 to result
        for (int j = 0; j < array2.Length; j++)
        {
            result[array1.Length + j] = array2[j];
        }

        return result;
    } */

//Using a StringBuilder (for String representations of integers):
/* {
        StringBuilder result = new StringBuilder();

        // Append elements from array1 to result
        foreach (int num in array1)
        {
            result.Append(num.ToString());
        }

        // Append elements from array2 to result
        foreach (int num in array2)
        {
            result.Append(num.ToString());
        }

        return result.ToString();
    } */

//Resizing the First Array (ArrayList-like Approach)
/* {
        // Create a new list to hold the concatenated elements
        List<int> result = new List<int>(list1);

        // Add elements from array2 to the result list
        for (int i = 0; i < array2.Length; i++)
        {
            result.Add(array2[i]);
        }

        return result;
    } */

/*     {
        List<int> result = new List<int>(array1);

        // Add elements from array2 to the result list
        result.AddRange(array2);

        return result.ToArray();
    } */

//Bulk copy
/*     {
        int[] result = new int[array1.Length + array2.Length];

        // Copy the first array
        Array.Copy(array1, result, array1.Length);

        // Copy the second array
        Array.Copy(array2, 0, result, array1.Length, array2.Length);

        return result;
    } */

//pointers XD
/*    unsafe {
        int totalLength = array1.Length + array2.Length;
        int[] result = new int[totalLength];

        fixed (int* pResult = result, pArray1 = array1, pArray2 = array2)
        {
            int* pCurrent = pResult;
            int* pEnd = pResult + totalLength;

            for (int* p = pArray1; p < pArray1 + array1.Length; p++)
            {
                *pCurrent = *p;
                pCurrent++;
            }

            for (int* p = pArray2; p < pArray2 + array2.Length; p++)
            {
                *pCurrent = *p;
                pCurrent++;
            }
        }

        return result;
    } */

//StringBuilder
/* {
        StringBuilder result = new StringBuilder();
        
        // Append elements from array1 to result
        foreach (int num in array1)
        {
            result.Append(num.ToString());
        }
        
        // Append elements from array2 to result
        foreach (int num in array2)
        {
            result.Append(num.ToString());
        }
        
        return result.ToString();
    } */

//preallocation
/*     {
        int totalLength = arr1.Length + arr2.Length;
        int[] concatenatedArray = new int[totalLength];

        // Copy elements from arr1 to concatenatedArray
        for (int i = 0; i < arr1.Length; i++)
        {
            concatenatedArray[i] = arr1[i];
        }

        // Copy elements from arr2 to concatenatedArray
        for (int j = 0; j < arr2.Length; j++)
        {
            concatenatedArray[arr1.Length + j] = arr2[j];
        }

        return concatenatedArray;
    } */

/*     {
        int[] concatenatedArray = new int[arr1.Length + arr2.Length];

        // Copy elements from arr1 to concatenatedArray
        Array.Copy(arr1, 0, concatenatedArray, 0, arr1.Length);

        // Copy elements from arr2 to concatenatedArray
        Array.Copy(arr2, 0, concatenatedArray, arr1.Length, arr2.Length);

        return concatenatedArray;
    } */

//Span<T>
/*     {
        int[] concatenatedArray = new int[arr1.Length + arr2.Length];
        Span<int> span = new Span<int>(concatenatedArray);

        // Copy elements from arr1 and arr2 using spans
        arr1.CopyTo(span);
        arr2.CopyTo(span.Slice(arr1.Length));

        return concatenatedArray;
    } */

//i give up, all is O(n+m)
/*  public unsafe static int[] ConcatArrays(int[] arr1, int[] arr2)
    {
        // Allocate memory for the concatenated array
        int totalLength = arr1.Length + arr2.Length;
        int* concatenatedArrayPtr = stackalloc int[totalLength];
        int* currentPtr = concatenatedArrayPtr;

        // Copy elements from arr1 to concatenated array
        for (int i = 0; i < arr1.Length; i++)
        {
            *currentPtr = arr1[i];
            currentPtr++;
        }

        // Copy elements from arr2 to concatenated array
        for (int i = 0; i < arr2.Length; i++)
        {
            *currentPtr = arr2[i];
            currentPtr++;
        }

        // Convert the concatenated array from a pointer to an array
        int[] concatenatedArray = new int[totalLength];
        currentPtr = concatenatedArrayPtr;
        for (int i = 0; i < totalLength; i++)
        {
            concatenatedArray[i] = *currentPtr;
            currentPtr++;
        }

        return concatenatedArray;
    } */