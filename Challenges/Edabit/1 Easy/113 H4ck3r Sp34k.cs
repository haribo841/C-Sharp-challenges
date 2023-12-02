//Create a function that takes a number as an argument, increments the number by +1 and returns the result.
using System;

namespace Challenges
{
    public class Program113
    {
        public static string HackerSpeak(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'a':
                        chars[i] = '4';
                        break;
                    case 'e':
                        chars[i] = '3';
                        break;
                    case 'i':
                        chars[i] = '1';
                        break;
                    case 'o':
                        chars[i] = '0';
                        break;
                    case 's':
                        chars[i] = '5';
                        break;
                    default:
                        break;
                }
            }
            return new string(chars);
        }
    }
}
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