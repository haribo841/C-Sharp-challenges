using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests136
    {
        [TestCase("mice", 5, ExpectedResult = "mmmmmiiiiiccccceeeee")]
        [TestCase("hello", 3, ExpectedResult = "hhheeellllllooo")]
        [TestCase("stop", 1, ExpectedResult = "stop")]
        [TestCase("tomato", 2, ExpectedResult = "ttoommaattoo")]
        public static string TestRepeat(string str, int num)
        {
            return Program136.Repeat(str, num);
        }
    }
}