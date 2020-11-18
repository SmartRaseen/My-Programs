
using System;
					
public class Program
{
	public static void Main()
	{
	 	string data="Raseen Is Try To Become A Very Good Boy...";
		Console.Write(data);
		char[] array = data.ToCharArray(0,5);
		Console.WriteLine("\n");
		foreach(char c in array)
			Console.Write(c);
		string productName = new string(array);
		Console.WriteLine("\n"+productName);
	}
}