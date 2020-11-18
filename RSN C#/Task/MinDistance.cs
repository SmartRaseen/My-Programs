using System; 
  
public class program 
{       
	public static void Main(string[] args) 
    {	
		int i,limit=10;
        int[] arr = {3,7,11,17,9,26,22,13,6,28};
		
		/*for(i=0;i<limit;i++)
		{
    		arr[i]=i;
    	}*/
        
		for(i=0;i<limit;i++)
		{
			Console.WriteLine(" Array ["+i+"] : "+arr[i]);
		}
		Console.WriteLine("\n Length Of The Array : "+arr.Length);
		
		Array.Sort(arr);
		Console.WriteLine("\n Sorting Of Array Is : \n");
		
		foreach (int a in arr) 
		Console.Write(" " +a);
		
		Console.WriteLine();
		int minDiff = arr[1]-arr[0];
		
		for (i=2; i!=arr.Length ; i++) 
		{
    	minDiff = Math.Min(minDiff, arr[i]-arr[i-1]);
		}
		
		Console.WriteLine("\n Minimum Distance Is : "+minDiff);
    } 
}