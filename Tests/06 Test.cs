using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests6
    {
        [Test]
        [TestCase(3, 2, 3, TestName = "base {0} with height 60 should give an area of {1}")]
        [TestCase(5, 4, 10, TestName = "base {0} with height 60 should give an area of {1}")]
        [TestCase(10, 10, 50, TestName = "base {0} with height 60 should give an area of {1}")]
        [TestCase(0, 60, 0, TestName = "base {0} with height 60 should give an area of {1}")]
        [TestCase(12, 11, 66, TestName = "base {0} with height 60 should give an area of {1}")]
        public void TriArea(int b, int h, int expectedResult)
        {
            // Arrange
            int triangleBase = b;
            int triangleHeight = h;
            // Act
            int result = Program6.TriArea(triangleBase, triangleHeight);
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}