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
																					Sample[8] : 8
																					Sample[9] : 9		

// Two Dimensional Array

using System;
					
public class Program
{
	public static void Main()
	{
		int i,j;
		int[,] sample=new int[5,2] {{0,0},{1,2},{2,4},{3,6},{4,8}};
		
		for(i=0;i<5;i++)
		{
			for(j=0;j<2;j++)
			{
				Console.WriteLine("sample[{0},{1}] = {2}",i,j,sample[i,j]);
			}
		}

	}
}

//output
sample[0,0] = 0
sample[0,1] = 0
sample[1,0] = 1
sample[1,1] = 2
sample[2,0] = 2
sample[2,1] = 4
sample[3,0] = 3
sample[3,1] = 6
sample[4,0] = 4
sample[4,1] = 8
																					
//Three Dimensional Array

using System;
					
public class Program
{
    public static void Main()
	{
		int i,j,k;
	    int[,,] sample=new int[2,2,3] { { {1,2,3},{4,5,6} }, { {7,8,9},{10,11,12} } };
		
		for(i=0;i<2;i++)
		{
			for(j=0;j<2;j++)
			{
				for(k=0;k<3;k++)
				{
			Console.WriteLine("sample[{0},{1},{2}] = {3}",i,j,k,sample[i,j,k]);
				}
			}
		}
	}
}

//Output

sample[0,0,0] = 1
sample[0,0,1] = 2
sample[0,0,2] = 3
sample[0,1,0] = 4
sample[0,1,1] = 5
sample[0,1,2] = 6
sample[1,0,0] = 7
sample[1,0,1] = 8
sample[1,0,2] = 9
sample[1,1,0] = 10
sample[1,1,1] = 11
sample[1,1,2] = 12	

//jagged Array

using System;
					
public class Program
{
    public static void Main()
	{
		int[][] jagged=new int[3][];
		
		jagged[0]=new int[4];
		jagged[1]=new int[3];
		jagged[2]=new int[5];
		
		int i;
		
		for(i=0;i<4;i++)
		{
			jagged[0][i]=i;
		}
		
		for(i=0;i<3;i++)
		{
			jagged[1][i]=i;
		}
		
		for(i=0;i<5;i++)
		{
			jagged[2][i]=i;
		}
		
		//Display Values
		
		for(i=0;i<4;i++)
		{
			Console.WriteLine(jagged[0][i]);
		}
		
		for(i=0;i<3;i++)
		{
			Console.WriteLine("\t"+jagged[1][i]);
		}
		
		for(i=0;i<5;i++)
		{
			Console.WriteLine(jagged[2][i]);
		}
		
		Console.WriteLine("GetUpperBound(0)"+jagged.GetUpperBound(0));
		Console.WriteLine("GetUpperBound(1)"+jagged[0].GetUpperBound(0));
		Console.WriteLine("GetUpperBound(2)"+jagged[1].GetUpperBound(0));
		Console.WriteLine("GetUpperBound(3)"+jagged[2].GetUpperBound(0));
	}
}

//Output

0
1
2
3
    0
    1
    2
0
1
2
3
4
GetUpperBound(0)2
GetUpperBound(1)3
GetUpperBound(2)2
GetUpperBound(3)4
																				
																					
// Same Program In Another Method
																					
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