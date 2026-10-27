//Create a function to extract the name of the subreddit from its URL.
using System;

namespace Challenges
{
    public static class Program145
    {
        public static string SubReddit(string link) => new Uri(link).Segments[2].TrimEnd('/');

    }
}
