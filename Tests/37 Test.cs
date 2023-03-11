//Here's an image of four models. Some of the cubes are hidden behind other cubes.
//Model one consists of one cube. Model two consists of four cubes, and so on...
//Write a function that takes a number n and returns the number of stacked boxes in a model n levels high, visible and invisible.
using System;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests37
    {
        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        [TestCase(0, 0)]
        [TestCase(5, 25)]
        [TestCase(27, 729)]
        [TestCase(196, 38416)]
        [TestCase(512, 262144)]
        public void FixedTest(int a, int expectedResult)
        {
            int result = Program37.StackBoxes(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}