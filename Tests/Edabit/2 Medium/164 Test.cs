using System;
using Challenges;
using Challenges.Edabit;
using Microsoft.Diagnostics.Runtime.Utilities;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests164
    {
        [Test]
        [TestCase("Happy Birthday", "hAPPY bIRTHDAY")]
        [TestCase("MANY THANKS", "many thanks")]
        [TestCase("sPoNtAnEoUs", "SpOnTaNeOuS")]
        [TestCase("eXCELLENT, yOuR mAJESTY", "Excellent, YoUr Majesty")]
        public void FixedTest(string str, string expectedResult)
        {
            string result = Program164.ReverseCase(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}