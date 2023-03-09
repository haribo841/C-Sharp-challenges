//Emmy has written a function that returns a greeting to users.
//However, she's in love with Mubashir, and would like to greet him slightly differently.
//She added a special case in her function, but she made a mistake.
//Can you help her?
using System;
public class Program25
{
    public static string greeting(string name)
    {
        if (name == "Mubashir")
        {
            return "Hello, my Love!";
        }
        else
        {
            return "Hello, " + name + "!";
        }
    }
}