//You are counting points for a basketball game,
//given the amount of 3-pointers scored and 2-pointers scored,
//find the final points for the team and return that value
//([2 -pointers scored, 3-pointers scored]).
public class Tests
{
  [Test]
	[TestCase(1, 1, Result=5)]
	[TestCase(1, 2, Result=8)]
	[TestCase(2, 1, Result=7)]
	[TestCase(2, 2, Result=10)]
	[TestCase(69, 420, Result=1398)]

	public static int Points(int twoPointers, int threePointers)
	{
		Console.WriteLine($"Input: {twoPointers} {threePointers}");
		return Program.Points(twoPointers, threePointers);
	}
public class Program 
{
    public static int Points(int twoPointers, int threePointers) 
    {
		public static int Points(int twoPointers, int threePointers)=>twoPointers*2+threePointers*3;
		//int a;
        //Console.Write( a = Points(69,420));
    }
}