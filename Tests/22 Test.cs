using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests22
    {
        [Test]
        [TestCase(1, 2, 3, 5, TestName = "{0} wins and {1} draws makes {3} points")]
        [TestCase(5, 5, 5, 20, TestName = "{0} wins and {1} draws makes {3} points")]
        [TestCase(1, 0, 0, 3, TestName = "{0} wins and {1} draws makes {3} points")]
        [TestCase(0, 7, 0, 7, TestName = "{0} wins and {1} draws makes {3} points")]
        [TestCase(0, 0, 15, 0, TestName = "{0} wins and {1} draws makes {3} points")]
        public void FixedTest(int a, int b, int c, int expectedResult)
        {
            // Arrange
            int wins = a;
            int draws = b;
            int losses = c;
            int result = Program22.FootballPoints(wins, draws, losses);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
