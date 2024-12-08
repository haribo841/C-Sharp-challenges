/*Something is wrong with global snow production, and you've been selected to take a look.
The Elves have even given you a map; on it, they've used stars to mark the top fifty locations that are likely to be having problems.
You've been doing this long enough to know that to restore snow operations, you need to check all fifty stars by December 25th.
Collect stars by solving puzzles.
Two puzzles will be made available on each day in the Advent calendar; the second puzzle is unlocked when you complete the first.
Each puzzle grants one star. Good luck!
You try to ask why they can't just use a weather machine ("not powerful enough") and where they're even sending you ("the sky")
and why your map looks mostly blank ("you sure ask a lot of questions") and hang on did you just say the sky ("of course, where do you think snow comes from")
when you realize that the Elves are already loading you into a trebuchet ("please hold still, we need to strap you in").
As they're making the final adjustments, they discover that their calibration document (your puzzle input)
has been amended by a very young Elf who was apparently just excited to show off her art skills.
Consequently, the Elves are having trouble reading the values on the document.
The newly-improved calibration document consists of lines of text;
each line originally contained a specific calibration value that the Elves now need to recover.
On each line, the calibration value can be found by combining the first digit and the last digit (in that order) to form a single two-digit number.
For example:
1abc2
pqr3stu8vwx
a1b2c3d4e5f
treb7uchet
In this example, the calibration values of these four lines are 12, 38, 15, and 77.
Adding these together produces 142.
Consider your entire calibration document.
What is the sum of all of the calibration values?
*/
//--- Part Two ---
/*Your calculation isn't quite right.
It looks like some of the digits are actually spelled out with letters:
one, two, three, four, five, six, seven, eight, and nine also count as valid "digits".
Equipped with this new information, you now need to find the real first and last digit on each line.
For example:
two1nine
eightwothree
abcone2threexyz
xtwone3four
4nineeightseven2
zoneight234
7pqrstsixteen
In this example, the calibration values are 29, 83, 13, 24, 42, 14, and 76.
Adding these together produces 281.
What is the sum of all of the calibration values?
*/
using System;
using System.Collections;
using System.Reflection;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Challenges
{
    public class A2301
    {
        public static int Trebuchet(string filePath)
        {
            try
            {
                int sum = 0;

                // Open the file and create a StreamReader to read it
                using StreamReader reader = new(filePath);
                string? line;

                // Read and process each line separately
                while ((line = reader.ReadLine()) != null)
                {
                    int firstDigit = -1;
                    int lastDigit = -1;

                    foreach (char c in line)
                    {
                        if (char.IsDigit(c))
                        {
                            if (firstDigit == -1)
                            {
                                firstDigit = c - '0'; // Convert character to numeric value
                                break;
                            }
                        }
                    }

                    for (int i = line.Length - 1; i >= 0; i--)
                    {
                        if (char.IsDigit(line[i]))
                        {
                            if (lastDigit == -1)
                            {
                                lastDigit = line[i] - '0'; // Convert character to numeric value
                                break;
                            }
                        }
                    }

                    if (firstDigit != -1 && lastDigit != -1)
                    {
                        sum += firstDigit * 10 + lastDigit;
                    }
                }

                return sum;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Please check the file path.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return 0;
        }


        public static int Trebuchet2(string filePath)
        {
            static int GetCalibrationValue(string input, string[] wordToDigit, int[] digitValues)
            {
                int FindIndex(string word)
                {
                    for (int i = 0; i < wordToDigit.Length; i++)
                    {
                        if (wordToDigit[i] == word)
                        {
                            return i + 1; // Increment by 1 to match digit index
                        }
                    }
                    return 0; // Return 0 if the word is not found
                }
                char firstChar = input[0];
                char lastChar = input[^1];
                int firstDigit = Char.IsDigit(firstChar) ? int.Parse(firstChar.ToString()) : digitValues[FindIndex(firstChar.ToString())];
                int lastDigit = Char.IsDigit(lastChar) ? int.Parse(lastChar.ToString()) : digitValues[FindIndex(lastChar.ToString())];
                return firstDigit * 10 + lastDigit;
            }
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File not found. Please check the file path.");
                    return 0;
                }
                string[] wordToDigit = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                int[] digitValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int sum = 0;
                string pattern = @"\b(" + string.Join("|", Array.ConvertAll(wordToDigit, Regex.Escape)) + @")\b";
                using (StreamReader reader = new(filePath))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        MatchCollection matches = Regex.Matches(line, pattern);
                        foreach (Match match in matches)
                        {
                            int calibrationValue = GetCalibrationValue(match.Value, wordToDigit, digitValues);
                            sum += calibrationValue;
                        }
                    }
                }
                return sum;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return 0;
            }
        }
    }
}