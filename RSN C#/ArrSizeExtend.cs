using System;

public class rsn
{
	public static void Main(string[] args)
	{
		int i;
		
		int[] array = new int[10];
		
		int[] array1 = null;
		
		for(i=0;i<10;i++)
		{
			array[i]=i;
			Console.WriteLine("Array["+i+"] : "+array[i]);
		}
		
		array1 = new int[10+array.Length];
		
		Console.WriteLine("\n");
		
		for(i=0;i<array.Length;i++)
		{
			array[i]=i;
			Console.WriteLine("Array["+i+"] : "+array[i]);
		}
		
		for(i=array.Length;i<array1.Length;i++)
		{
			array1[i]=i;
			Console.WriteLine("Array["+i+"] : "+array1[i]);
		}
	}
}