//Christmas Eve is almost upon us, so naturally we need to prepare some milk and cookies for Santa!
//Create a function that accepts year, month and day as integers and returns true if it's Christmas Eve (December 24th) and false otherwise.
using System;

namespace Challenges
{
    public class Program35
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Usuń nieużywany parametr", Justification = "Żadne przeładowanie metody „TimeForMilkAndCookies” nie pobiera następującej liczby argumentów: 3")]
        public static bool TimeForMilkAndCookies(int year, int month, int day) => month == 12 && day == 24;
    }
}