using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Test61
    {
        [Test]
        [TestCase(new object[] { "Cat", "Dog", "Duck" }, "Duck")]
        [TestCase(new object[] { 1, 2, 3 }, 3)]
        [TestCase(new object?[] { null }, null)]
        [TestCase(new object[] { true, false, false, true }, true)]
        [TestCase(new object?[] { 7, "String", false, null, null }, null)]
        [TestCase(new object?[] { null }, null)]
        [TestCase(new object[] { false }, false)]
        [TestCase(new object?[] { null, null, null }, null)]
        [TestCase(new object[] { 1, 2, 3, 56, 87, 23, 65, 45 }, 45)]
        [TestCase(new object?[] { "Apple", "Orange", null }, null)]
        [TestCase(new object[] { true, false, "Apple" }, "Apple")]
        [TestCase(new object[] { 1 }, 1)]
        public void FixedTest(object[] arr, object expectedResult)
        {
            object result = Program61.GetLastItem(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

