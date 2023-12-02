//Write a function that returns the string "something" joined with a space " " and the given argument a.
using System;

namespace Challenges
{
    public class Program11
    {
        public static string GiveMeSomething(string a) => "something " + a;
    }
}
//return $"something {a}";
//return a.Insert(0, "something ");
//		string b = "something ";
//return (b + a);
//		string give = "something " + a; 
//return give;
//string.Concat(fName, lName);
/*
 * // Using String.Join(String, String[])
int[] intArray = { 1, 3, 5, 7, 9 };
String seperator = ", ";
string result = "Int, ";
result += String.Join(seperator, intArray);

// Using String.Join(String, String[], int int)
// Let's concatenate first two strings of the array
String[] arr2 = { "Mahesh Chand ", "Chris Love ", "Dave McCarter ", "Praveen Kumar " };
String seperator2 = ", ";
string result2 = "First Author, ";
result2 += String.Join(seperator2, arr2, 1, 2);
Console.WriteLine($"Result: {result2}");

/* *** Simple String.Format **/
//string date = String.Format("Today's date is {0}", DateTime.Now);
//Console.WriteLine(date);

/*
 * System.Text.StringBuilder builder = new System.Text.StringBuilder("Mahesh Chand");
builder.Append(", ");
builder.Append("Chris Love");
builder.Append(", Praveen Kumar");
C#
The following code example creates a string of numbers from 0 to 999 and each number is separated by a comma and a space. 

System.Text.StringBuilder numbers = new System.Text.StringBuilder();
// Create a string of 1000 numbers from 0 to 999
// separated by a comma and space
for (int counter = 0; counter <= 999; counter++)
{
numbers.Append(counter);
numbers.Append(", ");
}
*/