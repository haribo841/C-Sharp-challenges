//Look at the examples below to get an idea of what the function should do.
using System;
using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class Tests
{
    [Test]
    public static void FixedTest()
    {
        List<int> myValues = new List<int>(new int[] { 1 });
        Assert.AreEqual(myValues, Mubashir.PrintArray(1));

        myValues = new List<int>(new int[] { 1, 2 });
        Assert.AreEqual(myValues, Mubashir.PrintArray(2));

        myValues = new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
        Assert.AreEqual(myValues, Mubashir.PrintArray(6));
    }
}
public class Loop
{
    public static List<int> PrintArray(int number)
    {
        List<int> array = new List<int>();

        for (int counter = 1; counter <= number;)
        {
            array.Add(counter);
        }

        return array;
    }
}