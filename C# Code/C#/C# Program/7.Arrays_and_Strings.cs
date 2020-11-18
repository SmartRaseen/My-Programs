

//One Dimensional array

using System;

public class Raseen																		
{
	public static void Main()
	{																				// Output
		int i;
		int[] sample=new int[10];													Sample[0] : 0			
		for(i=1;i<=10;i++)															Sample[1] : 1	
			sample[i]=i;															Sample[2] : 2		
		for(i=1;i<=10;i++)															Sample[3] : 3
			Console.WriteLine("Sample["+i+"] : "+sample[i]);						Sample[4] : 4
	}																				Sample[5] : 5
}																					Sample[6] : 6
																					Sample[7] : 7
// Same Program In Another Method													Sample[8] : 8
																					Sample[9] : 9		
public class Raseen
{
	public static void Main()
	{
		int i;
		int sample;
		for(i=0;i<10;i++)
			Console.WriteLine("Sample["+i+"] : "+i);
	}
}

// Average Of Set Of Value

public class Raseen
{
	public static void Main()															//Output
	{
		int[] nums=new int[10];													Average : 50
		int i,avg=0;
		nums[0]=10;
		nums[1]=11;
		nums[2]=22;
		nums[3]=33;
		nums[4]=44;
		nums[5]=55;
		nums[6]=66;
		nums[7]=77;
		nums[8]=88;
		nums[9]=99;
		for(i=0;i<10;i++)
		{
			avg=avg+nums[i];
		}	
			avg=avg/10;

			Console.WriteLine("Average : "+avg);
	}
}

public class Program
{
	public static void Main()
	{
		int[] num={1,2,3,4,5,6,7,8,9,0};												//Output
		int avg=0,i,sum=0;
																					Sum Is : 45
		for(i=0;i<10;i++)															
			sum=sum+num[i];															Avg Is : 4

		
		avg=sum/10;
		Console.WriteLine("\n Sum Is : "+sum);
		Console.WriteLine("\n Avg Is : "+avg);
	}
}

public class Program
{																											//Output
	public static void Main()
	{																										12		
		int[,] num={ {1,2},{2,3},{3,4},{4,5},{5,6},{6,7},{7,8},{8,9},{9,0},{10,1} };						23	
		int i,j;																							34
																											45
		for(i=0;i<10;i++){																					56	
			for(j=0;j<2;j++){																				67
				Console.Write(num[i,j]);																	78	
			}																								89
			Console.WriteLine();																			90
		}																									101
	}
}

// ForEach

public class Program																		//Output
{
	public static void Main()															Value Of X is : 0	
	{																					Value Of X is : 1	
		int i,sum=0;																	Value Of X is : 2		
		int[] num=new int[10];															Value Of X is : 3	
		 for(i=0;i<10;i++)																Value Of X is : 4
			 num[i]=i;																	Value Of X is : 5		
																						Value Of X is : 6		
																						Value Of X is : 7
		foreach(int x in num)															Value Of X is : 8				
		{																				Value Of X is : 9
			Console.WriteLine("Value Of X is : "+x);
			sum=sum+x;
		}
			Console.WriteLine("Sum Of X is : "+sum);
	}
}


// String

public class Program
{
	public static void Main()															//Output
	{
		char[] ch={'R','A','S','E','E','N'};										RASEEN
		Console.WriteLine("\n");
																					Hii Raseen..		
		string str1=new string(ch);
		string str2="Hii Raseen..";
			
			Console.WriteLine(str1);
			Console.WriteLine("\n");
			Console.WriteLine(str2);
	}
}


