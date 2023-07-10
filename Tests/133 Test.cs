using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests133
    {
        [Test]
        public void GenericTests()
        {
            int[] haystack_1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] haystack_2 = new int[] { 43, 65, 23, 89, 53, 9, 6 };
            int[] haystack_3 = new int[] { 718, 991, 449, 644, 380, 440 };
            int[] haystack_4 = new int[] { 148, 6, 16, 85 };
            int[] haystack_5 = new int[] { 9, 49, 23 };
            int[] haystack_6 = new int[] { 34, 43, 32, 49, 40 };
            int[] haystack_7 = new int[] { 1232, 1990, 1284, 1391, 1958 };
            int[] haystack_8 = new int[] { 2766, 2651, 2373, 2916, 2397, 2539 };
            int[] haystack_9 = new int[] { 53, 65, 52, 62, 59 };
            int[] haystack_10 = new int[] { 393, 156, 14, 166, 129, 246 };

            Assert.That(Program133.NoOdds(haystack_1), Is.EqualTo(new int[] { 2, 4, 6, 8 }));
            Assert.That(Program133.NoOdds(haystack_2), Is.EqualTo(new int[] { 6 }));
            Assert.That(Program133.NoOdds(haystack_3), Is.EqualTo(new int[] { 718, 644, 380, 440 }));
            Assert.That(Program133.NoOdds(haystack_4), Is.EqualTo(new int[] { 148, 6, 16 }));
            Assert.That(Program133.NoOdds(haystack_5), Is.EqualTo(new int[] { }));
            Assert.That(Program133.NoOdds(haystack_6), Is.EqualTo(new int[] { 34, 32, 40 }));
            Assert.That(Program133.NoOdds(haystack_7), Is.EqualTo(new int[] { 1232, 1990, 1284, 1958 }));
            Assert.That(Program133.NoOdds(haystack_8), Is.EqualTo(new int[] { 2766, 2916 }));
            Assert.That(Program133.NoOdds(haystack_9), Is.EqualTo(new int[] { 52, 62 }));
            Assert.That(Program133.NoOdds(haystack_10), Is.EqualTo(new int[] { 156, 14, 166, 246 }));
        }
    }
}