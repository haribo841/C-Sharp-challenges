using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests143
    {
        [Test]
        [TestCase("space", "s p a c e")]
        [TestCase("far out", "f a r   o u t")]
        [TestCase("elongated musk", "e l o n g a t e d   m u s k")]
        [TestCase("long", "l o n g")]
        [TestCase("123", "1 2 3")]
        [TestCase("a1b2c3", "a 1 b 2 c 3")]
        public static void FixedTest(string n, string expectedResult)
        {
            string result = Program143.SpaceMeOut(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}