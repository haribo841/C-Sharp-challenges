//Create a function that counts the number of syllables a word has.
//Each syllable is separated with a dash -.
namespace Challenges
{
    public static class Program98
    {
        public static int NumberSyllables(string word)
        {
            return 1 + word.Count(character => character == '-');
        }
    }
}
