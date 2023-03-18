using System;

namespace Challenges;
public class Power
{
    public static int DoPower(int a, int b)
    {
        if (a < 0) throw new ArgumentOutOfRangeException(nameof(a));
        if (b < 0) throw new ArgumentOutOfRangeException(nameof(b));
        int result = 1;
        for (int i = 0; i < b; i++)
            result *= a;
        return result;
    }
}
