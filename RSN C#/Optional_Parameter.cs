// Optional Parameter

using System;

public class rsn
{
	public static void Main(string[] args)
	{
		TestOptional();	
	}
	
	public static void Optional(int v1=100,int v2=200)
	{
		Console.WriteLine("\n\t The Value Of V1 is {0} , V2 is {1} : ",v1,v2);
		v1=v1*5;
		Console.WriteLine("\n\t The Value Of V1 is : "+v1);
		v2=v2+5;
		Console.WriteLine("\n\t The Value Of V1 is : "+v2);
	}
	
	public static void TestOptional()
	{
		int x=5;
		int y=25;
		Console.WriteLine("\n\t The Value Of  X = "+x+" , Y = "+y+"\n");
		Optional();
		Console.WriteLine("\n\n");
		Optional(x,y);
		Console.WriteLine("\n\n");
		Optional(v1:x,v2:y);  //Using Named Arguments
	}
}