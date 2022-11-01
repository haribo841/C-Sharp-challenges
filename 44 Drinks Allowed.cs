//A bartender is writing a simple program to determine whether he should serve drinks to someone.
//He only serves drinks to people 18 and older and when he's not on break.
//Given the person's age, and whether break time is in session, create a function which returns whether he should serve drinks.
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(17, true, Result = false)]
    [TestCase(30, true, Result = false)]
    [TestCase(24, false, Result = true)]
    [TestCase(18, false, Result = true)]
    [TestCase(16, false, Result = false)]
    [TestCase(18, true, Result = false)]
    [TestCase(17, false, Result = false)]
    public static bool FixedTest(int a, bool b)
    {
        return Program.ShouldServeDrinks(a, b);
    }
}
public class Program
{
    public static bool ShouldServeDrinks(int age, bool on_break)
    {

    }
}