//Properties

using System;

public class rsn
{																		//Output
	public int x;
	public void Set(int i)												//25
	{
		x=i;
	}
	public int Get()
	{
		return x;
	}
}

public class program
{
	public static void Main(string[] args)
	{
		rsn r = new rsn();
		r.Set(25);
		Console.WriteLine(r.Get());
	}
}