using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests71
    {
        [Test]
        [TestCase(new int[] { 10, 4, 1, 2, 8, 91 }, 90)]
        [TestCase(new int[] { -70, 43, 34, 54, 22 }, 124)]
        public void FixedTest(int[] arr, int expectedResult)
        {
            int result = Program71.DifferenceMaxMin(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}