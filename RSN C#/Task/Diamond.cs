using System;
					
public class Program
{
	public static void Main()
	{
		int i,j,k;
		Console.WriteLine("Create a Diamond output using nos between 1 to 9 with the help of nested loops");
		Console.WriteLine();
		for(i=1;i<=9;i++)
		{
			for(j=9;j>=i;j--)
			{
				Console.Write(" ");
			}
			for(k=1;k<=2*i-1;k++)
			{
				Console.Write(i);
			}
			Console.WriteLine();
		}
		
		for(i=1;i<=9;i++)
		{
			for(j=1;j<=i;j++)
			{
				Console.Write(" ");
			}
			for(k=17;k>=2*i-1;k--)
			{
				Console.Write(i);
			}
			Console.WriteLine();
		}
		
	}
}

