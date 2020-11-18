using System;
					
public class rect
{
	public int height,width;
	
	public rect(int w,int h)
	{ 														//Output
		width=w;
		height=h;											Area Of Object 1 : 200
	}
	public int area()										Area Of Object 2 : 1200		
	{
		return width*height;
	}
	
}
public class rsn_raseen 
{
	public static void Main()
	{
		rect r1=new rect(10,20);
		rect r2=new rect(30,40);
		Console.WriteLine("\n Area Of Object 1 : "+r1.area());
		Console.WriteLine("\n Area Of Object 2 : "+r2.area());
	}
}

