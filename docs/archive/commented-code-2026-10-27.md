# Historical commented implementations

The following commented-out alternatives were moved out of compiled C# files during the Sonar cleanup on 2026-10-27. They are preserved as historical reference, not as current implementations or newly validated benchmark results. Original names may use earlier exercise numbering.

## Challenges/Edabit/0 Very Easy/073 Find the Index.cs:21

~~~csharp
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
~~~

## Challenges/Edabit/0 Very Easy/076 Word Endings.cs:38

~~~csharp
/* public static string[] AddEndingParallelWithPreallocation(string[] arr, string ending)
    {
        string[] result = new string[arr.Length];
        int maxLength = 0;

        // Find the maximum length of strings in the input array
        foreach (string str in arr)
        {
            if (str.Length > maxLength)
                maxLength = str.Length;
        }

        // Process the strings in parallel and pre-allocate memory for the result strings
        Parallel.For(0, arr.Length, i =>
        {
            result[i] = new string(' ', maxLength + ending.Length);
            result[i] = arr[i] + ending;
        });

        return result;
    }

 {
        string[] result = new string[arr.Length];
        int maxLength = 0;

        // Find the maximum length of strings in the input array
        Parallel.For(0, arr.Length, i =>
        {
            int length = arr[i].Length + ending.Length;
            if (length > maxLength)
            {
                System.Threading.Interlocked.Exchange(ref maxLength, length);
            }
        });

        // Process the strings in parallel and pre-allocate memory for the result strings
        Parallel.For(0, arr.Length, i =>
        {
            result[i] = new string(' ', maxLength);
            result[i] = arr[i] + ending;
        });

        return result;
    } */
~~~

## Challenges/Edabit/0 Very Easy/086 Concatenating Two Integer Arrays.cs:20

~~~csharp
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
~~~

## Challenges/Edabit/0 Very Easy/086 Concatenating Two Integer Arrays.cs:39

~~~csharp
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
~~~

## Challenges/Edabit/0 Very Easy/086 Concatenating Two Integer Arrays.cs:58

~~~csharp
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
~~~

## Challenges/Edabit/0 Very Easy/086 Concatenating Two Integer Arrays.cs:71

~~~csharp
/*     {
        List<int> result = new List<int>(array1);

        // Add elements from array2 to the result list
        result.AddRange(array2);

        return result.ToArray();
    } */
~~~

## Challenges/Edabit/0 Very Easy/086 Concatenating Two Integer Arrays.cs:81

~~~csharp
/*     {
        int[] result = new int[array1.Length + array2.Length];

        // Copy the first array
        Array.Copy(array1, result, array1.Length);

        // Copy the second array
        Array.Copy(array2, 0, result, array1.Length, array2.Length);

        return result;
    } */
~~~

## Challenges/Edabit/0 Very Easy/086 Concatenating Two Integer Arrays.cs:94

~~~csharp
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
~~~

## Challenges/Edabit/0 Very Easy/086 Concatenating Two Integer Arrays.cs:120

~~~csharp
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
~~~

## Challenges/Edabit/0 Very Easy/086 Concatenating Two Integer Arrays.cs:139

~~~csharp
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
~~~

## Challenges/Edabit/0 Very Easy/086 Concatenating Two Integer Arrays.cs:158

~~~csharp
/*     {
        int[] concatenatedArray = new int[arr1.Length + arr2.Length];

        // Copy elements from arr1 to concatenatedArray
        Array.Copy(arr1, 0, concatenatedArray, 0, arr1.Length);

        // Copy elements from arr2 to concatenatedArray
        Array.Copy(arr2, 0, concatenatedArray, arr1.Length, arr2.Length);

        return concatenatedArray;
    } */
~~~

## Challenges/Edabit/0 Very Easy/086 Concatenating Two Integer Arrays.cs:171

~~~csharp
/*     {
        int[] concatenatedArray = new int[arr1.Length + arr2.Length];
        Span<int> span = new Span<int>(concatenatedArray);

        // Copy elements from arr1 and arr2 using spans
        arr1.CopyTo(span);
        arr2.CopyTo(span.Slice(arr1.Length));

        return concatenatedArray;
    } */
~~~

## Challenges/Edabit/0 Very Easy/086 Concatenating Two Integer Arrays.cs:183

~~~csharp
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
~~~

## Challenges/Edabit/0 Very Easy/088 Smash Factor.cs:13

~~~csharp
/* {
    double result = a / b;
    double roundedResult = Math.Floor(result * 100 + 0.5) / 100; // Round to two decimal places
    return roundedResult;
} */
~~~

## Challenges/Edabit/0 Very Easy/089 True Count.cs:12

~~~csharp
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
~~~

## Challenges/Edabit/0 Very Easy/091 Yen to USD.cs:11

~~~csharp
// => Math.Round(yen * 0.00930232558, 2);
~~~

## Challenges/Edabit/0 Very Easy/091 Yen to USD.cs:15

~~~csharp
/*
{
    const double ConversionFactor = 0.00930232558;
    return yen * ConversionFactor;
}
*/
~~~

## Challenges/Edabit/0 Very Easy/094 Find the Index.cs:23

~~~csharp
/*
{
    // Create a hash table to store the string-index pairs
    Dictionary<string, int> hashTable = new Dictionary<string, int>();

    // Populate the hash table with strings from the array
    for (int i = 0; i < arr.Length; i++)
    {
        // Check for duplicate strings
        if (hashTable.ContainsKey(arr[i]))
        {
            // Handle duplicates as needed (e.g., ignore, replace, etc.)
        }
        else
        {
            hashTable[arr[i]] = i;
        }
    }

    // Look up the index of the specified string
    if (hashTable.ContainsKey(str))
    {
        return hashTable[str];
    }
    else
    {
        return -1; // String not found in the array
    }
}
*/
~~~

## Challenges/Edabit/0 Very Easy/095 Back to Home.cs:32

~~~csharp
/*
{
    int x = 0;
    int y = 0;

    foreach (char direction in d)
    {
        switch (direction)
        {
            case 'N':
                y += 1;
                break;
            case 'S':
                y -= 1;
                break;
            case 'E':
                x += 1;
                break;
            case 'W':
                x -= 1;
                break;
            default:
                return false; // Invalid direction
        }
    }

    return x == 0 && y == 0;
}
*/
~~~

## Challenges/Edabit/1 Easy/104 To the Power.cs:25

~~~csharp
/*
{
    if (exponent < 0)
        throw new ArgumentException("Exponent must be non-negative.");
    if (exponent == 0)
        return 1;
    if (exponent == 1)
        return number;

    long halfPower = CalculateExponent(number, exponent / 2);
    long result = halfPower * halfPower;

    if (exponent % 2 == 1)
        result *= number;

    return result;
}
*/
~~~

## Challenges/Edabit/1 Easy/113 H4ck3r Sp34k.cs:38

~~~csharp
/*
{
    Dictionary<char, char> hackerSubstitutions = new Dictionary<char, char>
    {
        { 'a', '4' },
        { 'e', '3' },
        { 'i', '1' },
        { 'o', '0' },
        { 's', '5' }
    };

    StringBuilder result = new StringBuilder(str.Length);

    foreach (char c in str)
    {
        if (hackerSubstitutions.ContainsKey(c))
        {
            result.Append(hackerSubstitutions[c]);
        }
        else
        {
            result.Append(c);
        }
    }

    return result.ToString();
}
*/
~~~

## Challenges/Edabit/1 Easy/118 Shapes With N Sides.cs:25

~~~csharp
/*
{
    var shapeNames = new Dictionary<int, string>
    {
        { 1, "circle" },
        { 2, "semi-circle" },
        { 3, "triangle" },
        { 4, "square" },
        { 5, "pentagon" },
        { 6, "hexagon" },
        { 7, "heptagon" },
        { 8, "octagon" },
        { 9, "nonagon" },
        { 10, "decagon" }
    };

    return shapeNames.TryGetValue(n, out string shapeName) ? shapeName : "none";
}
*/
~~~

## Challenges/Edabit/1 Easy/123 Recursion Sum.cs:8

~~~csharp
// => n == 0 ? 0 : n + Sum(n - 1);
~~~

## Challenges/Edabit/1 Easy/128 Re-Form the Word.cs:14

~~~csharp
//result.Append(left[1..]);
~~~

## Challenges/Edabit/1 Easy/134 Reverse and Capitalize.cs:8

~~~csharp
//Invariant());
~~~

## Challenges/Edabit/1 Easy/142 Circle with OOP.cs:45

~~~csharp
//public class Program{
~~~

## Challenges/Edabit/1 Easy/143 Spaces Between Each Character.cs:22

~~~csharp
/*
 *     {
        StringBuilder spacedString = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            // Append the character
            spacedString.Append(input[i]);

            // Append a space if it's not the last character or a space
            if (i < input.Length - 1 && input[i] != ' ')
            {
                spacedString.Append(' ');
            }
        }

        return spacedString.ToString();
    } */
~~~

## Challenges/Edabit/1 Easy/144 Hashes and Pluses.cs:20

~~~csharp
/*
 * int a=0;
   int b=0;
            foreach (char c in s)
            {
                if (c == '#') a++;
                else if (c == '+') b++;
            }
            return new int [] {a,b};
*/
~~~

## Challenges/Edabit/1 Easy/145 Retrieve the Subreddit.cs:12

~~~csharp
/*
 *         {
            char[] chars = link.ToCharArray();
            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == 'r' && chars[i + 1] == '/')
                {
                    return link[(i + 2)..].TrimEnd('/');
                }
            }
            return "";
        }
*
             Uri uri;
            if (Uri.TryCreate(link, UriKind.Absolute, out uri))
            {
                string[] segments = uri.Segments;
                if (segments.Length >= 2 && segments[1] == "r/")
                {
                    return segments[2].TrimEnd('/');
                }
            }
            return "Invalid URL or Subreddit not found";
        }
*
*=> Uri.TryCreate(link, UriKind.Absolute, out Uri uri) && uri.Segments.Length >= 2 && uri.Segments[1] == "r/"
                ? uri.Segments[2].TrimEnd('/')
                : "Invalid URL or Subreddit not found";

        {
            string[] arr = link.Split(new char[] { '/' });
            if (arr[arr.Length-1].Length !=0 ) return arr[arr.Length - 1];
                return arr[arr.Length - 2];
        }
 */
~~~

## Challenges/Edabit/1 Easy/146 Last Digit Ultimate.cs:11

~~~csharp
/*
 using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Microsoft.CodeAnalysis;
using Microsoft.Diagnostics.Runtime.Utilities;
using System.Text;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Method
    {
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool F((int a, int b, int c) parameters) => parameters.a % 10 * parameters.b % 10 % 10 == parameters.c % 10;
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool FBody((int a, int b, int c) parameters)
        {
            return parameters.a % 10 * parameters.b % 10 % 10 == parameters.c % 10;
        }
        //Attempt 1
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool A((int a, int b, int c) parameters)
        {
            // Get the last digits as integers
            int A = int.Parse(parameters.a.ToString()[^1].ToString());
            int B = int.Parse(parameters.b.ToString()[^1].ToString());
            int C = int.Parse(parameters.c.ToString()[^1].ToString());

            // Check if the last digit of a * b equals the last digit of c
            return A * B % 10 == C;
        }
        //Attempt 2
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool B((int a, int b, int c) parameters)
        {
            int lastDigitA = parameters.a % 10;
            int lastDigitB = parameters.b % 10;
            int lastDigitC = parameters.c % 10;

            return lastDigitA * lastDigitB % 10 == lastDigitC;
        }
        //Attempt 3
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool Cbody((int a, int b, int c) parameters)
        {
            // Get the last digit of each number by converting to string
            char[] A = parameters.a.ToString().ToCharArray();
            char[] B = parameters.b.ToString().ToCharArray();
            char[] C = parameters.c.ToString().ToCharArray();
            // Convert the characters to integers before multiplication
            int lastDigitA = A[A.Length - 1] - '0';
            int lastDigitB = B[B.Length - 1] - '0';
            int lastDigitC = C[C.Length - 1] - '0';
            return lastDigitA * lastDigitB % 10 == lastDigitC;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool CbodyI((int a, int b, int c) parameters)
        {
            // Get the last digit of each number by converting to string
            char[] A = parameters.a.ToString().ToCharArray();
            char[] B = parameters.b.ToString().ToCharArray();
            char[] C = parameters.c.ToString().ToCharArray();
            // Convert the characters to integers before multiplication
            int lastDigitA = A[^1] - '0';
            int lastDigitB = B[^1] - '0';
            int lastDigitC = C[^1] - '0';
            return lastDigitA * lastDigitB % 10 == lastDigitC;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool Cbodys((int a, int b, int c) parameters)
        {
            // Get the last digit of each number by converting to string
            string A = parameters.a.ToString();
            string B = parameters.b.ToString();
            string C = parameters.c.ToString();
            // Convert the characters to integers before multiplication
            int lastDigitA = A[A.Length - 1] - '0';
            int lastDigitB = B[B.Length - 1] - '0';
            int lastDigitC = C[C.Length - 1] - '0';
            return lastDigitA * lastDigitB % 10 == lastDigitC;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool CbodysI((int a, int b, int c) parameters)
        {
            // Get the last digit of each number by converting to string
            string A = parameters.a.ToString();
            string B = parameters.b.ToString();
            string C = parameters.c.ToString();
            // Convert the characters to integers before multiplication
            int lastDigitA = A[^1] - '0';
            int lastDigitB = B[^1] - '0';
            int lastDigitC = C[^1] - '0';
            return lastDigitA * lastDigitB % 10 == lastDigitC;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool C((int a, int b, int c) parameters) =>
            (parameters.a.ToString().ToCharArray()[^1] - '0') * (parameters.b.ToString().ToCharArray()[^1] - '0') % 10 == (parameters.c.ToString().ToCharArray()[^1] - '0');
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool CS((int a, int b, int c) parameters) =>
    (parameters.a.ToString()[^1] - '0') * (parameters.b.ToString()[^1] - '0') % 10 == (parameters.c.ToString()[^1] - '0');
        //Attempt 4
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool DBody((int a, int b, int c) parameters)
        {
            {
                // Get the last digit of each number without using modulo
                int lastDigitA = GetLastDigit(parameters.a);
                int lastDigitB = GetLastDigit(parameters.b);
                int lastDigitC = GetLastDigit(parameters.c);

                // Compare the last digits
                return (lastDigitA * lastDigitB) % 10 == lastDigitC;
            }

            static int GetLastDigit(int number)
            {
                return Math.Abs(number % 10);
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool DNested((int a, int b, int c) parameters)
        {
            {
                // Get the last digit of each number without using modulo
                int lastDigitA = GetLastDigit(parameters.a);
                int lastDigitB = GetLastDigit(parameters.b);
                int lastDigitC = GetLastDigit(parameters.c);

                // Compare the last digits
                return (lastDigitA * lastDigitB) % 10 == lastDigitC;
            }

            static int GetLastDigit(int number)=>Math.Abs(number % 10);

        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool DTBody((int a, int b, int c) parameters)
        {
            {
                // Get the last digit of each number without using modulo

                // Compare the last digits
                return (GetLastDigit(parameters.a) * GetLastDigit(parameters.b)) % 10 == GetLastDigit(parameters.c);
            }

            static int GetLastDigit(int number)
            {
                return Math.Abs(number % 10);
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool DTemp((int a, int b, int c) parameters)
        {
            {
                // Get the last digit of each number without using modulo
                return GetLastDigit(parameters.a) * GetLastDigit(parameters.b) % 10 == GetLastDigit(parameters.c);
            }

            static int GetLastDigit(int number) => Math.Abs(number % 10);

        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool D((int a, int b, int c) parameters) => Math.Abs(parameters.a % 10) * Math.Abs(parameters.b % 10) % 10 == Math.Abs(parameters.c % 10);
        public IEnumerable<(int a, int b, int c)> GetData()
        {
            yield return (1, 1, 1);
            yield return (12, 15, 10);
            yield return (15228, 9209, 72162);
            yield return (15, 1, 1);
            yield return (123, 15, 10);
            yield return (5213, 99219, 6165);
            yield return (1523, 513, 512);
            yield return (-15, 1, 1);
            yield return (123, -15, 10);
            yield return (-12, 15, -10);
            yield return (15228, -9209, -72162);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var summary = BenchmarkRunner.Run<Method>();
            }
        }
    }
}
 */
~~~

## Challenges/Edabit/1 Easy/147 Quadratic Solutions.cs:12

~~~csharp
/*=> b * b - 4 * a * c < 0 ? 0 : b * b - 4 * a * c == 0 ? 1 : 2;
 *
 *         {
            int delta = b * b - 4 * a * c;
            //double x1 = -b + Math.Sqrt(delta) / 2 * a;
            //double x2 = -b - Math.Sqrt(delta) / 2 * a;
            return delta < 0 ? 0 : delta == 0 ? 1 : 2;//|| x1 == x2 ? 1 : 2;
        }
*
*    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            return 2; // Two real solutions
        }
        else if (discriminant == 0)
        {
            return 1; // One real solution
        }
        else
        {
            return 0; // No real solutions
        }
    }
*/
~~~

## Challenges/Edabit/1 Easy/148 Among Us Imposter Formula.cs:14

~~~csharp
/*
        public string A(int i, int p) => Math.Round(100 * ((double)i / p)).ToString() + "%";

        {
            return Math.Round(100 * ((double)i / p)).ToString() + "%";
        }

        public string Interp(int i, int p) => $"{Math.Round(100 * ((double)i / p)).ToString()}%";

        public string InterpBody(int i, int p)
        {
            return $"{Math.Round(100 * ((double)i / p)).ToString()}%";
        }

        public string InterpFix(int i, int p) => $"{Math.Round(100 * ((double)i / p))}%";

        public string FixBody(int i, int p)
        {
            return $"{Math.Round(100 * ((double)i / p))}%";
        }
*
*    {
        if (i < 0 || i > 3 || p < 1 || p > 10)
        {
            throw new ArgumentException("Invalid imposter count or player count.");
        }

        double chance = Math.Round(100.0 * i / p);
        return $"{chance}%";
    }
 */
~~~

## Challenges/Edabit/1 Easy/149 Remove Duplicates from an Array.cs:15

~~~csharp
/*
 *             // Create a new dictionary of strings, with string keys.
            Dictionary< object, int> openWith =new();
            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            for (int i = 0; i < str.Length; i++)
            {
                // The Add method throws an exception if the new key is
                // already in the dictionary.
                try
                {
                    openWith.Add( str[i], i);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("An element with Key = "+str[i]+" already exists.");
                }
            }
            return openWith.Keys.ToArray();
        }
*
*        {
            // Create a new dictionary of strings, with string keys.
            Dictionary< object, int> openWith =new();
            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            for (int i = 0; i < str.Length; i++)
            {
                object? item = str[i];
                if (!openWith.Keys.Contains(item))
                {
                    openWith.Add(str[i], i);
                }
            }
            return openWith.Keys.ToArray();
        }
*
*        {
            // Create a new dictionary of strings, with string keys.
            Dictionary<object, int> openWith = new();
            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            for (int i = 0; i < str.Length; i++)
            {
                object? item = str[i];
                if (!openWith.ContainsKey(item))
                {
                    openWith.Add(str[i], i);
                }
            }
            return openWith.Keys.ToArray();
        }
*
        {
            HashSet<object> seen = new HashSet<object>();
            List<object> result = new List<object>();

            foreach (var item in str)
            {
                if (!seen.Contains(item))
                {
                    result.Add(item);
                    seen.Add(item);
                }
            }

            return result.ToArray();
        }
 */
~~~

## Challenges/Edabit/1 Easy/150 Introduction to Recursion.cs:11

~~~csharp
/*
 * {
    if (num < 0)
    {
        throw new ArgumentException("Factorial is not defined for negative numbers.");
    }

    int result = 1;
    for (int i = 2; i <= num; i++)
    {
        result *= i;
    }
    return result;
}*/
~~~

## Challenges/Edabit/1 Easy/151 Palindrome.cs:20

~~~csharp
/*
 *         public static bool CheckPalindrome(string str)
        {
            char[] arr1  = str.ToCharArray();
            char[] arr2 = arr1.Reverse().ToArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }
            return true;
        }
*
         {
            if (string.IsNullOrEmpty(str))
                return false;

            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                    return false;

                left++;
                right--;
            }
*
            return true;
        }

        {
            if (string.IsNullOrEmpty(str))
                return false;

            StringBuilder reversed = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }

            return str.Equals(reversed.ToString());
        }
 */
~~~

## Challenges/Edabit/1 Easy/152 Vowel Replacer.cs:18

~~~csharp
/*
 *         {
            foreach (char item in str)
            {
                if (item is 'a' or 'e' or 'i' or 'o' or 'u' or 'y') str=str.Replace(item, ch[0]);
            }
            return str;
        }
*
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

            foreach (char item in vowels)
            {
                str = str.Replace(item, ch[0]);
            }

            return str;
        }
*
*        {
            string vowels = "aeiouy";
            foreach (char item in str)
            {
                if (vowels.Contains(item))
                {
                    str = str.Replace(item, ch[0]);
                }
            }
            return str;
        }
*
*        {
            static bool IsVowel(char c) => "aeiou".Contains(c);
            StringBuilder sb = new StringBuilder(str);

            for (int i = 0; i < sb.Length; i++)
            {
                char currentChar = sb[i];
                if (IsVowel(currentChar))
                {
                    sb[i] = ch[0];
                }
            }
            return sb.ToString();
        }
 */
~~~

## Challenges/Edabit/1 Easy/153 Between Words.cs:22

~~~csharp
/*
 *         {
            bool firstisfirst = false;
            bool lastislast = false;
            if (first.CompareTo(word) < 0) firstisfirst = true;
            if (word.CompareTo(last) <  0) lastislast = true;
            return lastislast == true && firstisfirst == true;
        }
*
*            bool firstIsFirst = first.CompareTo(word) < 0;
            bool lastIsLast = word.CompareTo(last) < 0;
            return firstIsFirst && lastIsLast;
*
*    {
        // Compare the strings and check if 'word' is between 'first' and 'last'
        int compareFirst = String.Compare(first, word);
        int compareLast = String.Compare(word, last);

        return compareFirst < 0 && compareLast < 0;
    }
*
*        {
            int firstComparison = word.CompareTo(first.Substring(0, Math.Min(first.Length, word.Length)));
            int lastComparison = word.CompareTo(last.Substring(0, Math.Min(last.Length, word.Length)));

            return firstComparison > 0 && lastComparison < 0;
        }
*
        {
            return String.Compare(first, word) < 0 && String.Compare(last, word) > 0;
        }
 *
         {
            string[] words = { first, last, word };
            Array.Sort(words);

            // Check if the word is in the middle position after sorting
            return words[1] == word;
        }
 */
~~~

## Challenges/Edabit/1 Easy/154 Equality of 3 Values.cs:20

~~~csharp
/*
 *         {
            if (a == b && b == c) return 3;
            if (a == b || b == c || a == c) return 2;
            return 0;
        }
 */
~~~

## Challenges/Edabit/1 Easy/155 Find the Index2.cs:38

~~~csharp
/*
 *         {
            if (arr[arr.Length - 1] == item) return arr.Length - 1;
            if(arr.Length == 0 ) return -1;
            int[] arr2 = arr.SkipLast(1).ToArray();
            return arr2.Length <= 0 ? -1 : Search(arr2, item);
        }
*
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if the target is at the middle
                if (arr[mid] == item)
                    return mid;

                // If the target is greater, ignore left half
                if (arr[mid] < item)
                    left = mid + 1;
                // If the target is smaller, ignore right half
                else
                    right = mid - 1;
            }

            // If the target is not present in the array
            return -1;
        }
*
*        {
            int RecursiveBinarySearch(int[] arr, int target, int left, int right)
            {
                if (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    // If the target is at the middle
                    if (arr[mid] == target)
                        return mid;

                    // If the target is greater, search the right half
                    if (arr[mid] < target)
                        return RecursiveBinarySearch(arr, target, mid + 1, right);
                    // If the target is smaller, search the left half
                    else
                        return RecursiveBinarySearch(arr, target, left, mid - 1);
                }

                // If the target is not present in the array
                return -1;
            }
            return RecursiveBinarySearch(arr, item, 0, arr.Length - 1);
        }
*
        {
            if (arr.Length == 0)
                return -1;

            if (arr[0] == item)
                return 0;

            int[] resizedArray = new int[arr.Length - 1];
            Array.Copy(arr, 1, resizedArray, 0, arr.Length - 1);

            int index = Search(resizedArray, item);
            if (index == -1)
                return -1;
            else
                return index + 1;
        }
*
        {
            int RecursiveSearch(int[] arr, int item, int index)
            {
                if (arr[index] == item)
                    return index;
                if (arr.Length == index + 1)
                    return -1;
                else
                    return RecursiveSearch(arr, item, index + 1);
            }
            return RecursiveSearch(arr, item, 0);
        }
*
        public static int Search(int[] arr, int item)
        {
            return RecursiveSearch(arr, item, 0);
        }

        private static int RecursiveSearch(int[] arr, int item, int index)
        {
            if (index >= arr.Length)
                return -1;

            if (arr[index] == item)
                return index;

            return RecursiveSearch(arr, item, index + 1);
        }
 */
~~~

## Challenges/Edabit/1 Easy/156 Find the Missing Number.cs:18

~~~csharp
/*
 *         {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr.Contains(i)) continue;
            return i;
        }
        return 10;
    }
*
*        {
            Array.Sort(arr); // Sort the array in ascending order

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    return i + 1; // If the number at index i is not i+1, i+1 is the missing number
                }
            }

            return arr.Length + 1; // If no missing number found, return the next number in the sequence
        }
*
    {
        int n = arr.Length + 1; // One number is missing, so the length is one less than the complete sequence
        int totalSum = n * (n + 1) / 2; // Sum of the complete sequence from 1 to n

        int arrSum = 0;
        foreach (int num in arr)
        {
            arrSum += num; // Sum of the elements in the given array
        }

        return totalSum - arrSum; // Finding the missing number
    }
 */
~~~

## Challenges/Edabit/1 Easy/157 Largest Swap.cs:24

~~~csharp
/*
 *         {
            string a= num.ToString();
            if (a[0] == a[1]) return true;
            else if (a[0] < a[1]) return false;
            return true;
        }
*
*        {
            int firstDigit = num / 10;  // Extracting the tens place digit
            int secondDigit = num % 10; // Extracting the ones place digit

            int swapped = secondDigit * 10 + firstDigit; // Creating the swapped number

            return num >= swapped; // Checking if the original number is greater than or equal to the swapped number
        }
 */
~~~

## Challenges/Edabit/1 Easy/158 Purge and Organize.cs:17

~~~csharp
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
~~~

## Challenges/Edabit/1 Easy/159 Valid Zip Code.cs:8

~~~csharp
// => zip.Length == 5 && int.TryParse(zip, out _);
~~~

## Challenges/Edabit/1 Easy/160 Remove Every Vowel from a String.cs:10

~~~csharp
// => Regex.Replace(str, "[aeiouAEIOU]", "");
~~~

## Challenges/Edabit/1 Easy/160 Remove Every Vowel from a String.cs:29

~~~csharp
/*                {
            // Use LINQ to filter out vowels
            string result = new string(str.Where(c => !"aeiouAEIOU".Contains(c) || c == ' ').ToArray());
            return result;
        }
 *
 *        {
            // Use LINQ to filter out vowels
            string result = new string(str.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
            return result;
        }
 *
 *         {
            // Use the Replace method to remove vowels
            return string.Join("", str.Split('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'));
        }
 *
 *         {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            StringBuilder sb = new();

            for (int i = 0; i < str.Length; i++)
            {
                if (!IsVowel(str[i]))
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }
*
*        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!IsVowel(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
*
*        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!"aeiouAEIOU".Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
*
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            foreach (char c in str)
            {
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
 */
~~~

## Challenges/Edabit/1 Easy/161 Letters Only.cs:10

~~~csharp
// => Regex.Replace(str, "[\\W\\d_]", "");
~~~

## Challenges/Edabit/1 Easy/161 Letters Only.cs:11

~~~csharp
//=> new string (str.Where(char.IsLetter).ToArray());
~~~

## Challenges/Edabit/1 Easy/161 Letters Only.cs:34

~~~csharp
/*
 * {
    int c = 0;
    char[] b = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsLetter(str[i])) // Use char.IsLetter to check if it's a letter
        {
            b[c] = str[i];
            c++;
        }
    }
    Array.Resize(ref b, c);
    return new string(b);
}
 *
 * {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
 */
~~~

## Challenges/Edabit/1 Easy/162 Map-Reduce Pattern.cs:12

~~~csharp
// => Math.Sqrt(arr.Sum(num => num * num));
~~~

## Challenges/Edabit/1 Easy/162 Map-Reduce Pattern.cs:13

~~~csharp
//Math.Sqrt(arr.Select(num => num * num).Sum());
~~~

## Challenges/Edabit/1 Easy/162 Map-Reduce Pattern.cs:24

~~~csharp
/*        {
            if (arr.Length == 0)
                return 0;

            Func<int, int> square = x => x * x;

            List<TResult> Map<T, TResult>(IEnumerable<T> source, Func<T, TResult> selector)
            {
                var result = new List<TResult>();
                foreach (var item in source)
                {
                    result.Add(selector(item));
                }
                return result;
            }

            TResult Reduce<T, TResult>(IEnumerable<T> source, Func<TResult, T, TResult> func, TResult seed)
            {
                TResult result = seed;

                foreach (var item in source)
                {
                    result = func(result, item);
                }

                return result;
            }

            var squaredValues = Map(arr, square);
            var sumOfSquaredValues = Reduce(squaredValues, (acc, val) => acc + val, 0);

            return Math.Sqrt(sumOfSquaredValues);
        }
 *
 * {
            if (arr.Length == 0)
                return 0;

            Func<int, int> square = x => x * x;

            List<TResult> Map<T, TResult>(IEnumerable<T> source, Func<T, TResult> selector)
            {
                var result = new List<TResult>();
                foreach (var item in source)
                {
                    result.Add(selector(item));
                }
                return result;
            }

            TResult Reduce<T, TResult>(IEnumerable<T> source, Func<TResult, T, TResult> func, TResult seed)
            {
                TResult result = seed;

                foreach (var item in source)
                {
                    result = func(result, item);
                }

                return result;
            }

            var squaredValues = Map(arr, square);
            var sumOfSquaredValues = Reduce(squaredValues, (acc, val) => acc + val, 0);

            return Math.Sqrt(sumOfSquaredValues);
        }
 *
 *         {
            double squaredSum = arr
                .Select(x => Math.Pow(x, 2))
                .Sum();

            double magnitude = Math.Sqrt(squaredSum);
            return magnitude;
        }
 *
 *         {
            if (arr.Length == 0)
                return 0;

            double squaredSum = arr.AsParallel()
                                      .Select(x => x * x)
                                      .Sum();

            return Math.Sqrt(squaredSum);
        }
 *
 *         {
            if (arr.Length == 0)
            {
                return 0;
            }

            double sumOfSquares = arr.Select(x => x * (double)x).Sum();
            double magnitude = Math.Sqrt(sumOfSquares);
            return magnitude;
        }
 */
~~~

## Challenges/Edabit/1 Easy/163 Cumulative Array Sum.cs:29

~~~csharp
/*          {
            if (arr == null || arr.Length == 0)
            {
                return new double[0];
            }

            double[] runningTotal = arr.Aggregate(
                new List<double>(),
                (a, i) =>
                {
                    if (a.Count == 0)
                    {
                        a.Add(i);
                    }
                    else
                    {
                        double sum = a.Last() + i;
                        a.Add(sum);
                    }
                    return a;
                }
            ).ToArray();

            return runningTotal;
        }
 *
 *          => (arr.Aggregate(
                new {sum=Enumerable.Empty<double>(), last = 0.0d},
                (a, c) => new {
                    sum = a.sum.Concat(Enumerable.Repeat(a.last+c,1)),
                    last = a.last + c
},
                a => a.sum
            ).ToArray());
    }
 *
 *  {
            if (arr.Length == 0)
            {
                return new double[0]; // Return an empty array if the input is empty
            }

            return arr.Select((x, i) => arr.Take(i + 1).Sum()).ToArray();
        }
 *
 *         {
            double[] cumulativeSums = new double[arr.Length];
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                cumulativeSums[i] = sum;
            }

            return cumulativeSums;
        }
 *
 *         {
            if (arr.Length == 0 ) return arr;
            for (int i = 1; i <= arr.Length - 1; i++) {
                arr[i] += arr[i-1];
            }
            return arr;
        }
*
        {
            var cumulative = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                cumulative[i] = arr[i] + (i == 0 ? 0 : cumulative[i - 1]);

            return cumulative;
        }
 */
~~~

## Challenges/Edabit/2 Medium/164 Reverse the Case.cs:23

~~~csharp
/*
 * {
            StringBuilder reversed = new StringBuilder(str.Length);

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        reversed.Append(char.ToLower(c));
                    }
                    else
                    {
                        reversed.Append(char.ToUpper(c));
                    }
                }
                else
                {
                    reversed.Append(c);
                }
            }

            return reversed.ToString();
        }
*
*        {
            string result = string.Empty;
            char[] inputArray = str.ToCharArray();

            foreach (char c in inputArray)
            {
                if (char.IsLower(c))
                    result += c.ToString().ToUpper();
                else if (char.IsUpper(c))
                    result += c.ToString().ToLower();
                else
                    result += c.ToString();
            }

            return result;
        }
*
*        {
            string result = string.Empty;
            char[] inputArray = str.ToCharArray();
            foreach (char c in inputArray)
            {
                if (char.IsLower(c))
                    result += Char.ToUpper(c);
                else
                    result += Char.ToLower(c);
            }
            return result;
        }
*
        {
            char[] charArray = str.ToCharArray();// new char[str.Length];

            for (int i = 0; i < charArray.Length; i++)//str.Length
            {
                if (char.IsLetter(charArray[i]))
                {
                    if (char.IsLower(charArray[i]))
                        charArray[i] = char.ToUpper(charArray[i]);
                    else
                        charArray[i] = char.ToLower(charArray[i]);
                }
            }

            return new string(charArray);
        }
*
*    {
        string[] reversedCharacters = new string[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsUpper(str[i]))
            {
                reversedCharacters[i] = Char.ToLower(str[i]).ToString();
            }
            else if (Char.IsLower(str[i]))
            {
                reversedCharacters[i] = Char.ToUpper(str[i]).ToString();
            }
            else
            {
                reversedCharacters[i] = str[i].ToString(); // Keep non-letter characters as they are
            }
        }

        return string.Concat(reversedCharacters);
    }
*
    {
        char[] charArray = str.ToCharArray();
        char[] newCharArray = new char[charArray.Length];

        for(int i=0; i<charArray.Length; i++)
        {
          if(char.IsUpper(charArray[i]))
            newCharArray[i] = Char.ToLower(charArray[i]);

          else if(char.IsLower(charArray[i]))
            newCharArray[i] = Char.ToUpper(charArray[i]);

          else
              newCharArray[i] = charArray[i];
        }

        string s = new string(newCharArray);
        return s;
    }
 */
~~~

## Challenges/Edabit/2 Medium/165 Array of Multiples.cs:19

~~~csharp
/*
 *     {
        int[] result = new int[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = num * (i + 1);
        }
        return result;
    }
*
{
        return Enumerable.Range(1, length).Select(x => x * num).ToArray();
    }
*
    {
        return Enumerable.Repeat(num, length).Select((x, index) => x * (index + 1)).ToArray();
    }
 */
~~~

## Challenges/Program.cs:30

~~~csharp
// BenchmarkRunner.Run<BenchmarkProgramNumber>(new CustomConfig());
~~~

## Additional fragments from exercises 091, 142 and 161

The following neighboring alternatives and the unused private rectangle example were also preserved while removing dead code from the current circle exercise.

### Exercise 091: alternate conversion expressions

~~~csharp
// => (yen * 100 / 10750.0);
// => yen * 0.00930232558;
// => (double)(yen * 0.00930232558);
~~~

### Exercise 161: regular-expression alternative

~~~csharp
//=> Regex.Replace(str, "[^a-zA-Z]", "");
~~~

### Exercise 142: unused private rectangle

~~~csharp
class Rectangle
{
    public double SideA;
    public double SideB;
    public Rectangle(double sideA, double sideB)
    {
        SideA = sideA;
        SideB = sideB;
    }
    public double GetArea() => SideA * SideB;
    public double GetPerimeter() => (SideA + SideB) * 2;
}
~~~

### Exercise 142: old console example

~~~csharp
//  public static void Main(int[] args){
//    var q = new Circle(4.44);
//    Console.WriteLine(q.GetArea());
//    Console.WriteLine(q.GetPerimeter());
//  }
//}
~~~
