//Create a function that returns the selected filename from a path. Include the extension in your answer.
using System;

namespace Challenges
{
    public class Program127
    {
        public static string GetFilename(string path)
        {
            int lastSlash=path.LastIndexOf('/');
            if (lastSlash == -1) { return path; }
            return path[++lastSlash..];
        }
    }
}