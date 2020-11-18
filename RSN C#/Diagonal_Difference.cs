using System;
using System.Linq;

/*	Math.Abs. An absolute value is not negative. 
	It is the same as the original value but with no negative sign. 
	The Math.Abs method in the .NET Framework provides a tested absolute value function. 
	It deals with certain edge cases.
*/

public class Program
{
	public static void Main()
	{
		int[,] temp = new int[3,3];
		int sub = 0;
		int leftDiagonal = 0;
		int rightDiagonal = 0;
		int row=3;
		int column=3;
		
		for(int i=0;i<row;i++)
		{					
			for(int j=0;j<column;j++)		// Get Values
			{
				temp[i,j] = Convert.ToInt32(Console.ReadLine());
			}
		}
		
		Console.WriteLine("\n\n");
		
		for(int i=0;i<row;i++)
		{
			for(int j=0;j<column;j++)		// Display Values
			{
				Console.Write(temp[i,j]);
			}
			Console.WriteLine();
		}
		
		for(int i=0;i<1;i++)
		{
			for(int j=0;j<column;j++)		// Get Left To Right
			{
				leftDiagonal += temp[i,j];
				i++;
			}
		}
		
		Console.WriteLine("\n\n LeftToRight Diagonal : " +leftDiagonal);
		
		for(int i=0;i<1;i++)
		{
			for(int j=column-1;j>=0;j--)	// Get Right To Left
			{
				rightDiagonal += temp[i,j];
				i++;
			}
		}
		
		Console.WriteLine("\n\n RightToLeft Diagonal : "+rightDiagonal);
		
		sub = rightDiagonal - leftDiagonal;
		
		int difference = Math.Abs(sub);
		
		Console.WriteLine("\n\n Difference : "+difference); // Display Difference
	}
}