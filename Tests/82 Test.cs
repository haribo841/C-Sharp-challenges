//Create a function that takes an array of values and returns the first and last values in a new array.
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests82
    {
        [Test]
        [TestCase(new object[] { 5, 10, 15, 20, 25 }, new object[] { 5, 25 })]
        [TestCase(new object?[] { "edabit", 13, null, false, true }, new object[] { "edabit", true })]
        [TestCase(new object?[] { "", 4, "6", "hello", null }, new object?[] { "", null })]
        [TestCase(new object[] { "hello", "edabit", "dot", "com" }, new object[] { "hello", "com" })]
        [TestCase(new object[] { 3, 2, 1 }, new object[] { 3, 1 })]
        [TestCase(new object[] { "one", "two" }, new object[] { "one", "two" })]
        [TestCase(new object[] { false, false, true, false, false, true, false }, new object[] { false, false })]
        public void FirstLast(object[] values, object[] expectedResult)
        {
            object[] result = Program82.FirstLast(values);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}