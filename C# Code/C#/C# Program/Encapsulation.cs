using System;
					
public class Rectangle
{
	public int length;
	public int width;
																		//Output
	public int GetArea()
	{																Arear Of Rectangle : 
		return length*width;										Length : 10 			
	}																Width : 15
		public void Display()										GetArea() : 150
		{
			Console.WriteLine("Length : {0} ",length);
			Console.WriteLine("Width : {0} ",width);
			Console.WriteLine("GetArea() : {0} ",GetArea());
		}
}
public class RectangleTester
{
	public static void Main()
	{
	Rectangle r=new Rectangle();
	r.length=10;
	r.width=15;
		Console.WriteLine("Arear Of Rectangle : ");
	r.Display();
	}
}
