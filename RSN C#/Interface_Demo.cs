//Interface

using System;

interface RSN
{
	void display();
}

public class program : RSN
{
	public static void Main(string[] args)
	{
	program p = new program();
		p.display();
	}
	
	public void display()
	{
		Console.WriteLine("Interface Name Is RSN");
	}
}