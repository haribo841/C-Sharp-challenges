//Create a function that counts the number of syllables a word has.
//Each syllable is separated with a dash -.
namespace Challenges
{
    public class Program98
    {
        public static int NumberSyllables(string word)
        {
            int syllableCount = 1; // Initialize to 1 because a single-word input has at least 1 syllable
            foreach (char c in word)
            {
                if (c == '-')
                {
                    syllableCount++;
                }
            }
            return syllableCount;
        }
    }
}
