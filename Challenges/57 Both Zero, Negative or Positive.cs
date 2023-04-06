//Write a function that returns true if both numbers are:
//Smaller than 0, OR ...
//Greater than 0, OR ...
//Exactly 0
//Otherwise, return false.
using System;
namespace Challenges
{
    public class Program57
    {
        public static bool Both(int n1, int n2) => (n1 < 0) && (n2 < 0) || (n1 == 0) && (n2 == 0) || (n1 > 0) && (n2 > 0);
    }
}