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
		Console.WriteLine("Are Of rectangle Is : "+c);
	}
}