//Create a function which returns "upper" if all the letters in a word are uppercase, "lower" if lowercase and "mixed" for any mix of the two.
using System;
using Challenges;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase("whisper...", Result = "lower")]
    [TestCase("SHOUT!", Result = "upper")]
    [TestCase("Indoor Voice", Result = "mixed")]
    [TestCase("324324Indoor66453546Voice434", Result = "mixed")]
    [TestCase("!!!!SHOUT!!!!", Result = "upper")]
    [TestCase("......313whisper2131232...", Result = "lower")]
    public static string FixedTest(string n, double expectedResult)
    {
        double result = Program91.YenToUsd(a);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
}
