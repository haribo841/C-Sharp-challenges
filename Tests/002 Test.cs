using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests2
    {
        [Test]
        [TestCase(6, 360, TestName = "{0} minutes should be converted to {1} seconds")]
        [TestCase(4, 240, TestName = "{0} minutes should be converted to {1} seconds")]
        [TestCase(8, 480, TestName = "{0} minutes should be converted to {1} seconds")]
        [TestCase(60, 3600, TestName = "{0} minutes should be converted to {1} seconds")]
        public void FixedTest(int a, int expectedResult)
        {
            int minutes = a;// Arrange
            int result = Program2.Convert(minutes);// Act
            Assert.That(result, Is.EqualTo(expectedResult));// Assert
        }
    }
}