using System;

public class Solution
{
	public static void Main()
	{
		byte byteHold = 255;	// Range byte is 0 to 255
		Console.WriteLine("\n Range of byte is 0 to 255");
		Console.WriteLine("\n byte Value : "+byteHold);
		Console.WriteLine("\n Type : "+byteHold.GetType());
		Console.WriteLine("___________________________________\n");
		
		sbyte sbyteHold = -128;	// Range sbyte is -128 to 127
		Console.WriteLine("\n Range of sbyte is -128 to 127");
		Console.WriteLine("\n sbyte Value : "+sbyteHold);
		Console.WriteLine("\n Type : "+sbyteHold.GetType());
		Console.WriteLine("___________________________________\n");
		
		short shortHold = 30000;  // Range short is -32,768 to 32,767
		Console.WriteLine("\n Range of short is -32,768 to 32,767");
		Console.WriteLine("\n short Value : "+shortHold);
		Console.WriteLine("\n Type : "+shortHold.GetType());
		Console.WriteLine("___________________________________\n");
		
		ushort ushortHold = 30000;  // Range ushort is 0 to 65,535
		Console.WriteLine("\n Range of ushort is 0 to 65,535");
		Console.WriteLine("\n ushort Value : "+ushortHold);
		Console.WriteLine("\n Type : "+ushortHold.GetType());
		Console.WriteLine("___________________________________\n");
		
		int intHold = 100000000;  // Range int is -2,147,483,648
								  //		      to  2,147,483,647
		Console.WriteLine("\n Range of int is -2,147,483,648 to 2,147,483,647");
		Console.WriteLine("\n int Value : "+intHold);
		Console.WriteLine("\n Type : "+intHold.GetType());
		Console.WriteLine("___________________________________\n");
		
		uint uintHold = 3000000000;  // Range uint is 0 to 4,294,967,295
		Console.WriteLine("\n Range uint is 0 to 4,294,967,295");
		Console.WriteLine("\n uint Value : "+uintHold);
		Console.WriteLine("\n Type : "+uintHold.GetType());
		Console.WriteLine("___________________________________\n");
		
		long longHold = 8000000000;  // Range -9,223,372,036,854,775,808
									 //     to 9,223,372,036,854,775,807
		Console.WriteLine("\n Range long is -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807");
		Console.WriteLine("\n long Value : "+longHold);
		Console.WriteLine("\n Type : "+longHold.GetType());
		Console.WriteLine("___________________________________\n");
		
		ulong ulongHold = 16000000000;  // Range 0 to 18,446,744,073,709,551,615
		Console.WriteLine("\n Range ulong is 0 to 18,446,744,073,709,551,615");
		Console.WriteLine("\n ulong Value : "+ulongHold);
		Console.WriteLine("\n Type : "+ulongHold.GetType());
		Console.WriteLine("___________________________________\n");
		
		float floatHold = 3.402823e26f;  // Range -3.402823e38 to 3.402823e38
		Console.WriteLine("\n Range float is -3.402823e38 to 3.402823e38");
		Console.WriteLine("\n float Value : "+floatHold);
		Console.WriteLine("\n Type : "+floatHold.GetType());
		Console.WriteLine("___________________________________\n");
		
		double doubleHold = 3.402823e26f;  // Range -3.402823e38 to 3.402823e38
		Console.WriteLine("\n Range double is -1.79769313486232e308 to 1.79769313486232e308");
		Console.WriteLine("\n double Value : "+doubleHold);
		Console.WriteLine("\n Type : "+doubleHold.GetType());
		Console.WriteLine("___________________________________\n");
	}
}