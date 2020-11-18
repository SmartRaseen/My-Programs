using System;
					
class Simple
{
	protected int height,width;
	public void getwidth(int w)
	{
		width=w;
	}
	public void getheight(int h)
	{
		height=h;
	}
}

public interface PaintCost
{														//Output
	int getcost(int area);
}													Total Area : 35
															
class Derived : Simple , PaintCost					paintCost Of Total Area : 2450
{
	public int getarea()
	{
	return width*height;
	}
	public int getcost(int area)
	{
	return area * 70;
	}
}
public class Tester
{
	public static void Main()
	{
		int area;
		Derived d=new Derived();
		d.getwidth(5);
		d.getheight(7);
		area=d.getarea();
		Console.WriteLine("Total Area : "+area);
		Console.WriteLine("PaintCost Of Total Area : $"+d.getcost(area));
	}
}