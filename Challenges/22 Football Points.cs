//Create a function that takes the number of wins,
//draws and losses and calculates the number of points a football team has obtained so far.
using System;

namespace Challenges
{
    public class Program22
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Usuñ nieu¿ywany parametr", Justification = "¯adne prze³adowanie metody „FootballPoints” nie pobiera nastêpuj¹cej liczby argumentów: 3")]
        public static int FootballPoints(int wins, int draws, int losses) => wins * 3 + draws;
    }
}