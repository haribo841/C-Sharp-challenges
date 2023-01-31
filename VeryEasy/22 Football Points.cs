//Create a function that takes the number of wins,
//draws and losses and calculates the number of points a football team has obtained so far.
using System;
public class Program22
{
    public static int FootballPoints(int wins, int draws, int losses)=>wins*3+draws;
}