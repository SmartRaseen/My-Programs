using System;
					
public class Program
{
	public static void Main()
	{
		int[] arr = {1,4,3,2};
		int n = arr.Length;
		
		for(;n>0;)									// Without Using  =  Array.Reverse(arr);
      		Console.Write(arr[--n] + " ");
	}
}

------------------------------------------------------------------------------------
using System;
public class Program
{
    public static void Main()
    {
        int[] array = { 1, 2, 3,4,5,6,7,8,9,10 };

        Array.Reverse(array);
        Console.WriteLine("Reversed Array : \n");
        foreach (int a in array)
        {
            Console.Write(" "+a);
        }
        Console.ReadLine();
    }
}