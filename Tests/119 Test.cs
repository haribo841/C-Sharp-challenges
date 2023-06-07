using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    public class Tests119
    {
        [Test]
        [TestCase("My friend Dylan got distracted at school", 4)]
        [TestCase("Debris was scattered all over the place.", 2)]
        [TestCase("The rodents hibernated in their den.", 3)]
        public void FixedTest(string str, int expectedResult)
        {
            int result = Program119.CountDs(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}