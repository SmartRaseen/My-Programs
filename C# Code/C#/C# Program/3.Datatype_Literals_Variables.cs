

		//	DataTypes, Literals And Variable's
		
		using System;
		
		public class data
		{																				//Output
			public static void Main()
			{																		Distance To The Sun Is : 5892480000000												
				long inches,miles=93000000;
				inches=miles*5280*12;
				Console.WriteLine("Distance To The Sun Is : "+inches);
			}
		}
		
		public class data
		{
			public static void Main()
			{
				byte x;																	//Output
				int sum=0;
				for(x=1;x<=100;x++)													The Summation Of 100 is : 5050
				{
					sum=sum+x;
				}
				Console.WriteLine("\n The Summation Of 100 is : "+sum);
			}
		}
		
		public class data
		{																				//Output
			public static void Main()
			{																		The radius Of The Circle Is :
				double r,area=10.0;
				r=Math.Sqrt(area/3.14);												Area is : 1.78457652562062
				Console.WriteLine("\n The radius Of The Circle Is :"+"\n \n Area is : "+r);
			}
		}
		
		
		public class Program
		{
			public static void Main()
			{
				bool b;																	//Output
				b=true;
				Console.WriteLine("bool b is : "+b+"\n");							bool b is : True
				b=false;
				Console.WriteLine("bool b is : "+b+"\n");							bool b is : False
				b=true;
				if(b) Console.WriteLine("\n This is Executed ");					This is Executed 
				b=false;
				if(b) Console.WriteLine("\n This is Not Executed ");				10>9 is :True
				Console.WriteLine("\n 10>9 is :"+(10>9));
			}
		}	
		
		public class Program
		{
			public static void Main()
			{
				int i;
				Console.WriteLine("Value\tSquare\tCube");
				for(i=1;i<=10;i++)
				{
				Console.WriteLine(" {0}\t\t{1}\t\t{2}",i,i*i,i*i*i);
				}
			}
		}
		
		public class Program
		{
			public static void Main()													
			{
				decimal price=19.95m;								
				decimal discount=0.15m;  //discount Price Is 15%						// Output
				decimal discount_price=price-(discount*price);
					Console.WriteLine("Discount Price: "+discount_price);			Discount Price: 16.9575
					Console.WriteLine("Discount Price: {0:C}",discount_price);		Discount Price: $16.96

			}
		}