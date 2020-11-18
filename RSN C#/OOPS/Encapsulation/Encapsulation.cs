
Encapsulation
*************

*	Encapsulation is defined 'as the process of enclosing one or more items within a physical or logical package'. 

*	Encapsulation, in object oriented programming methodology, prevents access to implementation details


using System;

public class Rectangle
{
	public double length;			// If you want to set variable as private, you didn't get the value from another class
	public double width;			// You get the data using Console.Readline();
	
	public double GetArea()
	{
		return length*width;
	}
	
	public void Display()
	{
		Console.WriteLine("Length : "+length);
		Console.WriteLine("Width : "+width);
		Console.WriteLine("Area : "+GetArea());
	}
}

public class TestRectangle
{
	public static void Main(string[] args)
	{
		Rectangle r = new Rectangle();
		r.length=4.5;
		r.width=5.5;
		r.Display();
		Console.ReadLine();
	}
} 