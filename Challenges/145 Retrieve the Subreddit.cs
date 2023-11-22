//Create a function to extract the name of the subreddit from its URL.
using System;

namespace Challenges
{
    public class Program145
    {
        public static string SubReddit(string link) => new Uri(link).Segments[2].TrimEnd('/');

    }
}
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