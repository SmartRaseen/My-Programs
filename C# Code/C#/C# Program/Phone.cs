using System;

public class Phone
{
	public void call(long a)
	{
		Console.WriteLine("Calling To.."+a);
	}
	public void receive(long d)
	{
		Console.WriteLine("Receive Call From "+d);
	}
}