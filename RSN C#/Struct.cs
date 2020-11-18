using System;

struct Book
{
	public string title;
	public string Name;
	public double cost;
}

public class program
{
	public static void Main(string[] args)
	{
		Book b;
		b.title="C";
		b.Name="Raseen";
		b.cost=250.50;
		Console.WriteLine("Book Title : "+b.title);
		Console.WriteLine("Book Name : "+b.Name);
		Console.WriteLine("Book Cost : "+b.cost);
		Console.ReadLine();
	}
}
