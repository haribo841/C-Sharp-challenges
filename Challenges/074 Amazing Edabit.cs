//Create a function that takes a string and changes the word amazing to not amazing.
//Return the string without any change if the word edabit is part of the string.
using System;
namespace Challenges
{
    public class Program74
    {
        public static string AmazingEdabit(string str) => str.Contains("edabit") ? str : str.Replace("amazing", "not amazing");
    }
}