//Create a function which validates whether a bridge is safe to walk on (i.e. has no gaps in it to fall through).
using System;
namespace Challenges
{
    public class Program51
    {
        public static bool IsSafeBridge(string str) => !str.Contains(' ');
    }
}