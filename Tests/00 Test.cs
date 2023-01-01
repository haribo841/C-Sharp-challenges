using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(Result=true)]
    public static bool FixedTest()
    {
        return Program.ReturnTrue();
    }
}
public class Program 
{
    public static bool ReturnTrue() 
    {
      return true;
    }
}