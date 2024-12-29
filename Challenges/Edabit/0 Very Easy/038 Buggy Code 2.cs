//Look at the examples below to get an idea of what the function should do.
using System;
using System.Collections.Generic;

namespace Challenges
{
    public class Loop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0090:Use 'new(...)'", Justification = "Intentional")]
        public static List<int> PrintArray(int number)
        {
            List<int> array = new List<int>();

            for (int counter = 1; counter <= number; counter++)
            {
                array.Add(counter);
            }

            return array;
        }
    }
}