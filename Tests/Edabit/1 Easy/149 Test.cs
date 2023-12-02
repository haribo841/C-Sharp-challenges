using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests149
    {
        [Test]
        [TestCase(new object[] { "John", "Taylor", "John" }, new object[] { "John", "Taylor" })]
        [TestCase(new object[] { "John", "Taylor", "John", "john" }, new object[] { "John", "Taylor", "john" })]
        [TestCase(new object[] { "javascript", "python", "python", "ruby", "javascript", "c", "ruby" }, new object[] { "javascript", "python", "ruby", "c" })]
        [TestCase(new object[] { 1, 2, 2, 2, 3, 2, 5, 2, 6, 6, 3, 7, 1, 2, 5 }, new object[] { 1, 2, 3, 5, 6, 7 })]
        [TestCase(new object[] { "#", "#", "%", "&", "#", "$", "&" }, new object[] { "#", "%", "&", "$" })]
        [TestCase(new object[] { 3, "Apple", 3, "Orange", "Apple" }, new object[] { 3, "Apple", "Orange" })]
        public void FixedTest(object[] str, object[] expectedResult)
        {
            object[] result = Program149.RemoveDups(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}