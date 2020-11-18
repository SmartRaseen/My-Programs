
Abstraction is "To represent the essential feature without representing the background details."

Abstraction is the process of hiding the working style of an object, and showing the information of an object in an understandable manner.


using System;
													
abstract class Shape
{
	public abstract int area();
}

class Rectangle : Shape
{
	private int length;
	private int width;
	public Rectangle (int a, int b)
	{
		length=a;
		width=b;
	}
	public override int area()
	{
		Console.WriteLine("Rectangle Of Area : ");
		return(length*width);
	}
}

public class RectangleTester 
{
	public static void Main()	
	{
		Rectangle r=new Rectangle(20,15);
		int c=r.area();
		Console.WriteLine("Area Of Rectangle Is : "+c);
	}
}

