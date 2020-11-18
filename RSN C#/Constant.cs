
	Constants
	*********
	
	*	The constants refer to fixed values that the program may not alter during its execution
	
	Example : Code
	**************
	
	using System;

	public class Program 
	{
		public static void Main(string[] args) 
		{
			const double pi = 3.14159;   
            
			// constant declaration 
			double r;
			Console.WriteLine("Enter Radius: ");
			r = Convert.ToDouble(Console.ReadLine());
            
			double areaCircle = pi * r * r;
			Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
			Console.ReadLine();
		}
    }
	
	Output :
	********
	
	Enter Radius : 3

	Radius: 3, Area: 28.27431
	