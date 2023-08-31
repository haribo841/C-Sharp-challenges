using Challenges;
using NUnit.Framework;
using System;
namespace Tests
{
    [TestFixture]
    public class Test105
    {
        [TestCase(new int[] { 2, 6, 4, 9 }, new int[] { 8, 24, 16, 36 })]
        [TestCase(new int[] { 4, 1, 1 }, new int[] { 12, 3, 3 })]
        [TestCase(new int[] { 1, 0, 3, 3, 7, 2, 1 }, new int[] { 7, 0, 21, 21, 49, 14, 7 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void TestMultiplyByLength(int[] input, int[] expectedOutput)
        {
            int[] result = Program105.MultiplyByLength(input);
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}
