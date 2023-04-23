using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests74
    {
        [Test]
        [TestCase("edabit is amazing.", "edabit is amazing.")]
        [TestCase("Mubashir is amazing.", "Mubashir is not amazing.")]
        [TestCase("Trump is amazing.", "Trump is not amazing.")]
        [TestCase("Infinity is amazing.", "Infinity is not amazing.")]
        [TestCase("Mubashir and edabit are amazing.", "Mubashir and edabit are amazing.")]
        [TestCase("Matt is amazing.", "Matt is not amazing.")]
        [TestCase("Helen is amazing.", "Helen is not amazing.")]
        [TestCase("Python and edabit are amazing.", "Python and edabit are amazing.")]
        [TestCase("C++ is amazing.", "C++ is not amazing.")]
        [TestCase("javascript is amazing.", "javascript is not amazing.")]
        [TestCase("java is amazing.", "java is not amazing.")]
        [TestCase("ruby is amazing.", "ruby is not amazing.")]
        [TestCase("SQL is amazing.", "SQL is not amazing.")]
        [TestCase("CSS is amazing.", "CSS is not amazing.")]
        [TestCase("Pakistan is amazing. edabit", "Pakistan is amazing. edabit")]
        [TestCase("You and edabit are amazing.", "You and edabit are amazing.")]
        [TestCase("Matt and edabit are amazing.", "Matt and edabit are amazing.")]
        [TestCase("Helen and edabit are amazing.", "Helen and edabit are amazing.")]
        [TestCase("Everyone is amazing.", "Everyone is not amazing.")]
        [TestCase("Swift and edabit are amazing.", "Swift and edabit are amazing.")]

        public void FixedTest(string a, string expectedResult)
        {
            string result = Program74.AmazingEdabit(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}