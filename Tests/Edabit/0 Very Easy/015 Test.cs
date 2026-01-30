using BenchmarkDotNet.Attributes;
using Challenges.Edabit;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests15
    {
        [Test]
        [TestCase("pokhara", "okhara", TestName = "{0} is not equal to {1}")]
        [TestCase("biratnagar", "iratnagar", TestName = "{0} is equal to {1}")]
        [TestCase("nepal", "epal", TestName = "{0} is not equal to {1}")]
        [TestCase("damak", "amak", TestName = "{0} is not equal to {1}")]
        [TestCase("itahari", "tahari", TestName = "{0} is equal to {1}")]
        [TestCase("rasuwa", "asuwa", TestName = "{0} is equal to {1}")]
        [TestCase("rolpa", "olpa", TestName = "{0} is equal to {1}")]
        public void FixedTest(string a, string expectedResult)
        {
            string result = Program15.NewWord(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}