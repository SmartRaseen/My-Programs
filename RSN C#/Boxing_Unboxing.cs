
Boxing and unboxing
*******************

The conversion of a value type to a reference type is known as boxing. 
Unboxing is just the opposite - it is defined as the process of conversion of a reference type to a value type. 

The following code snippet illustrates boxing and unboxing in C#.

int i = 100;

Object obj = i; //Boxing

i = (int) obj; //Unboxing

Example Code :

using System;
					
public class Program
{
	public static void Main()
	{
		int i=10;
		Console.WriteLine("Value of i = {0}",i);
		object obj = i;	// Boxing
		Console.WriteLine("Value of obj = {0}",obj);
		int x = (int) obj; // UnBoxing
		Console.WriteLine("Value of x = {0}",x);
	}
}

Output 
******

Value of i = 10
Value of obj = 10
Value of x = 10