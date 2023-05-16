//Create a function that takes a string and returns the word count.
//The string will be a sentence.
using NUnit.Framework;
[TestFixture]
public class Tests
{
    [Test]
    [TestCase("It's high noon", Result = 3)]
    [TestCase("Is this easy mode", Result = 4)]
    [TestCase("What an easy task, right", Result = 5)]
    [TestCase("This is a test", Result = 4)]
    [TestCase("Just an example here move along", Result = 6)]
    [TestCase("How are you today?", Result = 4)]
    public static int FixedTest(string str)
    {
        return Program.CountWords(str);
    }
}
public class Program
{
    public static int CountWords(string str)
    {

    }
}
