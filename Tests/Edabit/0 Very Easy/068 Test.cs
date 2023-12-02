using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests68
    {
        [Test]
        [TestCase("forza", "fa")]
        [TestCase("kali", "ki")]
        [TestCase("always", "as")]
        [TestCase("love", "le")]
        [TestCase("supernatural", "sl")]
        [TestCase("edabit", "et")]
        public void FixedTest(string a, object expectedResult)
        {
            object result = Program68.FirstLast(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}