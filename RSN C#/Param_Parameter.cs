//Param - variable length parameter

using System;

public class rsn
{
	public static void Main(string[] args)
	{
		TestAddParam();	
	}
	
	public static void AddParameter(params int[] arguments)
	{
		int add=0;
		Console.WriteLine("\n\t Param Length : "+arguments.Length);
			foreach(int argu in arguments)
			{
				add+=argu;
			}
		Console.WriteLine("\n\t Add : "+add);
	}
	
	public static void TestAddParam()
	{
		AddParameter(1);
		AddParameter(1,2,3,4,5);
	}
}