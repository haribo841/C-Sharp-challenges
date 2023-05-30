//Create a function that counts the number of syllables a word has.
//Each syllable is separated with a dash -.
namespace Challenges
{
    public class Program98
    {
        public static int NumberSyllables(string word)
        {
            string[] syllables = word.Split('-');
            return syllables.Length;
        }
    }
}
