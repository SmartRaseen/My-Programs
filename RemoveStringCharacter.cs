using System;
					
public class Program
{
	public static void Main()
	{  
		string category = "1,2,3,";  
		Console.WriteLine(category.Length);
		// Remove last character from a string  
		string categoryMinus1 = category.Remove(category.Length - 1, 1);  
		Console.WriteLine(categoryMinus1);
		
		Console.WriteLine("\n\n");
		
		string category1 = "1,2,3,,";  
		Console.WriteLine(category1.Length);
		// Remove last character from a string  
		string categoryMinus2 = category1.Remove(category1.Length - 2, 2);  
		Console.WriteLine(categoryMinus2);
	}
}

