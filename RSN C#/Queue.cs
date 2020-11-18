using System;
using System.Collections;

public class rsn
{
	public static void Main(string[] args)
	{
		Queue queue = new Queue();
		
		queue.Enqueue('R');
		queue.Enqueue('A');
		queue.Enqueue('S');
		queue.Enqueue('E');
		queue.Enqueue('E');
		queue.Enqueue('N');
		
	Console.WriteLine("\n Current Queue Is : ");
		
		foreach(char c in queue)
			Console.WriteLine("\n\t\t "+c);
		
		Console.WriteLine("\n\n Add Element 'R' ");
		queue.Enqueue('R');
		
		Console.WriteLine("\n");
		
		foreach(char c in queue)
			Console.WriteLine("\n\t\t "+c);

		Console.WriteLine("\n\n\t Peek Element : "+queue.Peek());
		
		Console.WriteLine("\n\n\t Remove Peek : "+queue.Peek());
		
		queue.Dequeue();
		Console.WriteLine("\n\n Current Queue Is : ");
		
		foreach(char c in queue)
			Console.WriteLine("\n\t\t "+c);
		
		Console.WriteLine("\n\n\t Queue Capacity Is : "+queue.Count);
		
		
	}
}