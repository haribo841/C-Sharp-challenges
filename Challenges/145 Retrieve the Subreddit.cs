//Create a function to extract the name of the subreddit from its URL.
using System;

namespace Challenges
{
    public class Program145
    {
        public static string SubReddit(string link)
        {
            char[] chars = link.ToCharArray();
            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == 'r' && chars[i + 1] == '/')
                {
                    return link.Substring(i + 2).TrimEnd('/');
                }
            }
            return "";
        }
    }
}