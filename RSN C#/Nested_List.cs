using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		List<List<int>> outerList = new List<List<int>>
    	{   
		new List<int>(){1, 2, 3},
        new List<int>(){4, 5, 6},
        new List<int>(){9, 8, 9}
    	};
		
		Console.WriteLine(outerList[0][1]);
		Console.WriteLine(outerList[1][1]);
	}
}


