//A bartender is writing a simple program to determine whether he should serve drinks to someone.
//He only serves drinks to people 18 and older and when he's not on break.
//Given the person's age, and whether break time is in session, create a function which returns whether he should serve drinks.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public class Program48
    {
            public static bool ShouldServeDrinks(int age, bool on_break) => !on_break && age >= 18;
    }
    public class BenchmarkProgram48
    {
        [Benchmark]
        [Arguments(17, true)]
        [Arguments(30, true)]
        [Arguments(24, false)]
        [Arguments(18, false)]
        [Arguments(16, false)]
        [Arguments(18, true)]
        [Arguments(17, false)]
        public bool ShouldServeDrinks(int age, bool on_break) => Program48.ShouldServeDrinks(age, on_break);
    }
}