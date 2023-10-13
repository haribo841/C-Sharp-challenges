//Create a function that takes 3 numbers: a, b, c and returns true if the last digit of a * b = the last digit of c.
using System;

namespace Challenges
{
    public class Program146
    {
        public static bool LastDig(int a, int b, int c) => a % 10 * b % 10 % 10 == c % 10;
    }
}
/*
        public bool BodyModulo(int a, int b, int c)
        {
            // Get the last digits of a, b, and c
            int lastDigitA = a % 10;
            int lastDigitB = b % 10;
            int lastDigitC = c % 10;

            // Check if the last digit of the product of a and b is equal to the last digit of c
            return (lastDigitA * lastDigitB) % 10 == lastDigitC;
        }
        public bool Parsing(int a, int b, int c) => (int.Parse(a.ToString()[^1].ToString()) * int.Parse(b.ToString()[^1].ToString())) % 10 == int.Parse(c.ToString()[^1].ToString());
        public bool ParsingBody(int a, int b, int c)
        {
            // Get the last digits as integers
            int A = int.Parse(a.ToString()[^1].ToString());
            int B = int.Parse(b.ToString()[^1].ToString());
            int C = int.Parse(c.ToString()[^1].ToString());

            // Check if the last digit of a * b equals the last digit of c
            return (A * B) % 10 == C;
        }
        public bool TryParse(int a, int b, int c)
        {
            // Get the last digits as integers
            char[] A = a.ToString().ToCharArray();
            char[] B = b.ToString().ToCharArray();
            char[] C = c.ToString().ToCharArray();
            int lastDigitA;
            if (int.TryParse(A[A.Length - 1].ToString(), out lastDigitA))
            {
                // Parsing successful
            }
            else
            {
                // Parsing failed, handle the error
            }
            int lastDigitB;
            if (int.TryParse(B[B.Length - 1].ToString(), out lastDigitB))
            {
                // Parsing successful
            }
            else
            {
                // Parsing failed, handle the error
            }
            int lastDigitC;
            if (int.TryParse(C[C.Length - 1].ToString(), out lastDigitC))
            {
                // Parsing successful
            }
            else
            {
                // Parsing failed, handle the error
            }
            // Check if the last digit of a * b equals the last digit of c
            return (lastDigitA * lastDigitB) % 10 == lastDigitC;
        }
        public bool TryParseBuiltIn(int a, int b, int c)
        {
            // Get the last digits as integers
            char[] A = a.ToString().ToCharArray();
            char[] B = b.ToString().ToCharArray();
            char[] C = c.ToString().ToCharArray();
            if (int.TryParse(A[A.Length - 1].ToString(), out int lastDigitA))
            {
                // Parsing successful
            }
            else
            {
                // Parsing failed, handle the error
            }
            if (int.TryParse(B[B.Length - 1].ToString(), out int lastDigitB))
            {
                // Parsing successful
            }
            else
            {
                // Parsing failed, handle the error
            }
            if (int.TryParse(C[C.Length - 1].ToString(), out int lastDigitC))
            {
                // Parsing successful
            }
            else
            {
                // Parsing failed, handle the error
            }
            // Check if the last digit of a * b equals the last digit of c
            return lastDigitA * lastDigitB % 10 == lastDigitC;
        }
        public bool TryParseIndex(int a, int b, int c)
        {
            // Get the last digits as integers
            char[] A = a.ToString().ToCharArray();
            char[] B = b.ToString().ToCharArray();
            char[] C = c.ToString().ToCharArray();
            int lastDigitA;
            if (int.TryParse(A[^1].ToString(), out lastDigitA))
            {
                // Parsing successful
            }
            else
            {
                // Parsing failed, handle the error
            }
            int lastDigitB;
            if (int.TryParse(B[^1].ToString(), out lastDigitB))
            {
                // Parsing successful
            }
            else
            {
                // Parsing failed, handle the error
            }
            int lastDigitC;
            if (int.TryParse(C[^1].ToString(), out lastDigitC))
            {
                // Parsing successful
            }
            else
            {
                // Parsing failed, handle the error
            }
            // Check if the last digit of a * b equals the last digit of c
            return (lastDigitA * lastDigitB) % 10 == lastDigitC;
        }
        public bool TryParseIndexBuiltIn(int a, int b, int c)
        {
            // Get the last digits as integers
            char[] A = a.ToString().ToCharArray();
            char[] B = b.ToString().ToCharArray();
            char[] C = c.ToString().ToCharArray();
            if (int.TryParse(A[^1].ToString(), out int lastDigitA))
            {
                // Parsing successful
            }
            else
            {
                // Parsing failed, handle the error
            }
            if (int.TryParse(B[^1].ToString(), out int lastDigitB))
            {
                // Parsing successful
            }
            else
            {
                // Parsing failed, handle the error
            }
            if (int.TryParse(C[^1].ToString(), out int lastDigitC))
            {
                // Parsing successful
            }
            else
            {
                // Parsing failed, handle the error
            }
            // Check if the last digit of a * b equals the last digit of c
            return lastDigitA * lastDigitB % 10 == lastDigitC;
        }
        public bool Converting(int a, int b, int c)
        {
            // Get the last digits as integers
            char[] A = a.ToString().ToCharArray();
            char[] B = b.ToString().ToCharArray();
            char[] C = c.ToString().ToCharArray();
            int lastDigitA = Convert.ToInt32(A[A.Length - 1].ToString());
            int lastDigitB = Convert.ToInt32(B[B.Length - 1].ToString());
            int lastDigitC = Convert.ToInt32(C[C.Length - 1].ToString());
            return (lastDigitA * lastDigitB) % 10 == lastDigitC;
        }
        public bool ConvertingIndex(int a, int b, int c)
        {
            // Get the last digits as integers
            char[] A = a.ToString().ToCharArray();
            char[] B = b.ToString().ToCharArray();
            char[] C = c.ToString().ToCharArray();
            int lastDigitA = Convert.ToInt32(A[A.Length - 1].ToString());
            int lastDigitB = Convert.ToInt32(B[B.Length - 1].ToString());
            int lastDigitC = Convert.ToInt32(C[C.Length - 1].ToString());
            return (lastDigitA * lastDigitB) % 10 == lastDigitC;
        }
        public bool LINQ(int a, int b, int c)
        {
            // Get the last digits as integers
            char[] A = a.ToString().ToCharArray();
            char[] B = b.ToString().ToCharArray();
            char[] C = c.ToString().ToCharArray();
            int lastDigitA = A.Last() - '0';
            int lastDigitB = B.Last() - '0';
            int lastDigitC = C.Last() - '0';
            return (lastDigitA * lastDigitB) % 10 == lastDigitC;
        }
        public bool ParseBody(int a, int b, int c)
        {
            // Get the last digits as integers
            char[] A = a.ToString().ToCharArray();
            char[] B = b.ToString().ToCharArray();
            char[] C = c.ToString().ToCharArray();
            int lastDigitA = int.Parse($"{A[A.Length - 1]}");
            int lastDigitB = int.Parse($"{B[B.Length - 1]}");
            int lastDigitC = int.Parse($"{C[C.Length - 1]}");
            return (lastDigitA * lastDigitB) % 10 == lastDigitC;
        }
        public bool ParseIndex(int a, int b, int c)
        {
            // Get the last digits as integers
            char[] A = a.ToString().ToCharArray();
            char[] B = b.ToString().ToCharArray();
            char[] C = c.ToString().ToCharArray();
            int lastDigitA = int.Parse($"{A[^1]}");
            int lastDigitB = int.Parse($"{B[^1]}");
            int lastDigitC = int.Parse($"{C[^1]}");
            return (lastDigitA * lastDigitB) % 10 == lastDigitC;
        }
        public bool NestedFunction(int a, int b, int c)
        {
            int GetLastDigit(int number)
            {
                return Math.Abs(number % 10);
            }
            // Get the last digit of each number without using modulo
            int lastDigitA = GetLastDigit(a);
            int lastDigitB = GetLastDigit(b);
            int lastDigitC = GetLastDigit(c);

            // Compare the last digits
            return (lastDigitA * lastDigitB) % 10 == lastDigitC % 10;
        }
        public bool LastDigIndex(int a, int b, int c)
        {
            // Get the last digit of each number by converting to string
            char[] A = a.ToString().ToCharArray();
            char[] B = b.ToString().ToCharArray();
            char[] C = c.ToString().ToCharArray();
            // Convert the characters to integers before multiplication
            int lastDigitA = A[^1] - '0';
            int lastDigitB = B[^1] - '0';
            char[] AB = (lastDigitA * lastDigitB).ToString().ToCharArray();
            int lastDigitAB = AB[^1] - '0';
            int lastDigitC = C[^1] - '0';
            return lastDigitAB == lastDigitC;
        }
        public bool LastDig(int a, int b, int c)
        {
            // Get the last digit of each number by converting to string
            char[] A = a.ToString().ToCharArray();
            char[] B = b.ToString().ToCharArray();
            char[] C = c.ToString().ToCharArray();
            // Convert the characters to integers before multiplication
            int lastDigitA = A[A.Length - 1] - '0';
            int lastDigitB = B[B.Length - 1] - '0';
            char[] AB = (lastDigitA * lastDigitB).ToString().ToCharArray();
            int lastDigitAB = AB[AB.Length - 1] - '0';
            int lastDigitC = C[C.Length - 1] - '0';
            return lastDigitAB == lastDigitC;
        }
*/