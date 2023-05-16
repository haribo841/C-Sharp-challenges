//Create a function that takes a string and returns the word count.
//The string will be a sentence.
using NUnit.Framework;
[TestFixture]
public class Tests
{
    [Test]
    [TestCase("It's high noon", 3)]
    [TestCase("Is this easy mode", 4)]
    [TestCase("What an easy task, right", 5)]
    [TestCase("This is a test", 4)]
    [TestCase("Just an example here move along", 6)]
    [TestCase("How are you today?", 4)]
    public static int FixedTest(string str