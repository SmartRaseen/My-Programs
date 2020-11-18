
// Access Modifiers

using System;
					
class Program
{
	private int alpha;  //private access explicitly specified
	int beta;	//private access by default
	public int gamma;	//public class
	
	public void setalpha(int a)
	{
		alpha=a;
	}
	public int getalpha()
	{
		return alpha;
	}
	public void setbeta(int b)
	{
		beta=b;
	}
	public int getbeta()
	{
		return beta;
	}
}
public class AccessDemo
{
	public static void Main()
	{
		Program p=new Program();
		p.setalpha(25);
		p.setbeta(05);
		Console.WriteLine("p.alpha is : "+p.getalpha());
		Console.WriteLine("p.beta is : "+p.getbeta());
	p.gamma=99;
	}
}