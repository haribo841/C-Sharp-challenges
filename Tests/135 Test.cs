using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests135
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
        [TestCase(new int[] { 5, 1, 9, 5, 5, 5, 4, 4, 6, 8 }, ExpectedResult = "(519) 555-4468")]
        [TestCase(new int[] { 3, 4, 5, 5, 0, 1, 2, 5, 2, 7 }, ExpectedResult = "(345) 501-2527")]
        [TestCase(new int[] { 6, 6, 2, 5, 8, 8, 7, 0, 4, 3 }, ExpectedResult = "(662) 588-7043")]
        [TestCase(new int[] { 5, 1, 0, 2, 6, 6, 3, 5, 8, 3 }, ExpectedResult = "(510) 266-3583")]
        [TestCase(new int[] { 4, 9, 7, 8, 8, 9, 1, 0, 1, 5 }, ExpectedResult = "(497) 889-1015")]
        [TestCase(new int[] { 6, 1, 9, 4, 7, 2, 8, 0, 7, 4 }, ExpectedResult = "(619) 472-8074")]
        [TestCase(new int[] { 7, 7, 3, 7, 8, 3, 6, 0, 8, 7 }, ExpectedResult = "(773) 783-6087")]
        [TestCase(new int[] { 9, 5, 3, 1, 3, 7, 4, 0, 0, 1 }, ExpectedResult = "(953) 137-4001")]
        [TestCase(new int[] { 2, 2, 6, 4, 0, 4, 4, 2, 9, 2 }, ExpectedResult = "(226) 404-4292")]
        public static string TestFormatPhoneNumber(int[] numbers)
        {
            return Program135.FormatPhoneNumber(numbers);
        }
    }
}