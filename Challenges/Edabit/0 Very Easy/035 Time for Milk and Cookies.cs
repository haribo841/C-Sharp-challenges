//Christmas Eve is almost upon us, so naturally we need to prepare some milk and cookies for Santa!
//Create a function that accepts year, month and day as integers and returns true if it's Christmas Eve (December 24th) and false otherwise.
using System;

namespace Challenges
{
    public class Program35
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Usu� nieu�ywany parametr", Justification = "�adne prze�adowanie metody �TimeForMilkAndCookies� nie pobiera nast�puj�cej liczby argument�w: 3")]
        public static bool TimeForMilkAndCookies(int year, int month, int day) => month == 12 && day == 24;
    }
}