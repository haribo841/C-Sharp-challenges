using NUnit.Framework;
using System;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Test0
    {
        [Test]
        public void FixedTest()
        {
            bool result = Program.ReturnTrue();// Act
            Assert.IsTrue(result);
        }
    }
}