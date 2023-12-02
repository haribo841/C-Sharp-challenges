using Challenges.Edabit;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class Test0
    {
        [Test]
        public void FixedTest()
        {
            bool result = Program.ReturnTrue();// Act
            Assert.That(result, Is.True);
        }
    }
}