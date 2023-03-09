using System;

namespace Challenges;
public class Power
{
    public int DoPower(int a, int b)
    {
        if (a < 0) throw new ArgumentOutOfRangeException("a");
        if (b < 0) throw new ArgumentOutOfRangeException("b");
        int result = 1;
        for (int i = 0; i < b; i++)
            result *= a;
        return result;
    }
}
