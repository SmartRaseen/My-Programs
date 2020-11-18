using System;
			
			// Basic
			
public class Program
{
	public static void Main()
	{																// Output
		int x=100,y=x/2;											
		Console.WriteLine("\n X Contains "+x);						X Contains 100
		Console.WriteLine("\n Y Contains x / 2: "+y);				Y Contains x / 2: 50
	}
}

			// Datatype Int,Double

	public static void Main()
	{																							// Output	
		int ivar=100;
		double dvar=100.0;																	Original Value Of ivar: 100								
		Console.WriteLine("\n Original Value Of ivar: "+ivar);											
		Console.WriteLine("\n Original Value Of dvar: "+dvar);								Original Value Of dvar: 100
		
		Console.WriteLine();																ivar after division: 33			
		ivar=ivar/3;																							
		dvar=dvar/3;																		dvar after division: 33.3333333333333					
		Console.WriteLine("\n ivar after division: "+ivar);																		
		Console.WriteLine("\n dvar after division: "+dvar);																		
	}
	
			// Area Of Circle
	
		public static void Main()
	{
		int radius;
		double pi=3.14;
		double area,circle;																	//Output
		Console.WriteLine("\n Enter The Radius Of The Circle : ");
		radius=Convert.ToInt32(Console.ReadLine());										Enter The Radius Of The Circle : 10
		Console.WriteLine();
		area=radius*radius*pi;															 Area Of Circle : 314
		circle=2*pi*radius;
		Console.WriteLine("\n Area Of Circle : "+area);									Circumference Of Circle : 62.8
		Console.WriteLine("\n Circumference Of Circle : "+circle);
	}
	

			// Using If Condition
	
	public static void Main()
	{
		int a=2,b=3,c;
		if(a<b)
			Console.WriteLine("\n A is Lesser Than B \n");
		if(a==b)
			Console.WriteLine("\n You Want See \n");										//Output
		if(a<b)
			Console.WriteLine("\n B is Less Than A Statement Is Wrong \n");				A is Lesser Than B 	
		  c=a-b;
			Console.WriteLine("\n C Contains -1\n");									B is Less Than A Statement Is Wrong 
		if(c>=0)
			Console.WriteLine("\n C Is Non Negative \n");								C Contains -1
		if(c<0)
			Console.WriteLine("\n C Is Negative \n");									C Is Negative 
		c=b-a;
			Console.WriteLine("\n C Contains 1\n");										C Contains 1	
		if(c>=0)
			Console.WriteLine("\n C Is Non Negative \n");								C Is Non Negative
		if(c<0)
			Console.WriteLine("\n C Is Negative \n");
				
	}
	
			// Using For Loop
	
	public static void Main()
	{																						//Output
		int count;																					
		for(count=0;count<=4;count++)													This Is Count : 0
		{																				This Is Count : 1
			Console.WriteLine("This Is Count : "+count);								This Is Count : 2			
		}																				This Is Count : 3	
		Console.WriteLine("\n Done!");													This Is Count : 4
	}
																						Done!

	
			// Sum And Product Of Number 1 To 10
			
			
	public static void Main()
	{
		int i,sum=0,prod=1;																	//Output
		for(i=1;i<=10;i++)
		{																				Sum Is : 55	
			sum=sum+i;
			prod=prod*i;																Prod Is : 3628800

		}
		Console.WriteLine("\n Sum Is : "+sum);
		Console.WriteLine("\n Prod Is : "+prod);
	}