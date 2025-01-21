//Create a function that takes in a word and determines whether or not it is plural.
//A plural word is one that ends in "s".
using BenchmarkDotNet.Attributes;
namespace Challenges
{
    public class Program62
    {
        public static bool IsPlural(string word) => word[^1] == 's';
    }
    public class BenchmarkProgram62
    {
        [Benchmark]
        [Arguments("dudes")]
        [Arguments("flowers")]
        [Arguments("checks")]
        [Arguments("varies")]
        [Arguments("efforts")]
        [Arguments("mood")]
        [Arguments("whiteboard")]
        [Arguments("cow")]
        [Arguments("word")]
        [Arguments("love")]
        public bool IsPlural(string word) => Program62.IsPlural(word);
    }
}
