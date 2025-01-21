//In this challenge, a farmer is asking you to tell him how many legs can be counted among all his animals.
//The farmer breeds three species:
//chickens = 2 legs
//cows = 4 legs
//pigs = 4 legs
//The farmer has counted his animals and he gives you a subtotal for each species.
//You have to implement a function that returns the total number of legs of all the animals.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program21
    {
        public static int Animals(int chickens, int cows, int pigs) => (chickens << 1) + ((cows + pigs) << 2);
    }
    public class BenchmarkProgram21
    {
        [Benchmark]
        [Arguments(5, 2, 8)]
        [Arguments(3, 4, 7)]
        [Arguments(1, 2, 3)]
        [Arguments(3, 5, 2)]
        public int Animals(int chickens, int cows, int pigs) => Program21.Animals(chickens, cows, pigs);
    }
}