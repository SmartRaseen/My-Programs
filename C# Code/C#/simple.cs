using System;
public class simple 
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter The Price Of Book : ");
		double a=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter The Price Of Ticket : ");
		float b=float.Parse(Console.ReadLine());
		Console.WriteLine("The Date Of Tomorrow : ");
		int c=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The Author Gender : ");
		char d=Convert.ToChar(Console.ReadLine());
		//long e=Console.ReadLine();
		Console.WriteLine("The Name Of Book : ");
		string values=Console.ReadLine();
		Console.WriteLine("The Price Of Book Is : "+a);
		Console.WriteLine("The Price Of Ticket Is  : "+b);
		Console.WriteLine("The Tomorrow Of Date Is  : "+c);
		Console.WriteLine("The Author Gender Is  : "+d);
		//Console.WriteLine("The Register Number Is  : "+e);
		Console.WriteLine("The Name Of Book Is  : "+values);
	}
}