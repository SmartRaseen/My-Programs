

public class Program
{
	public static void Main()
	{																										// Output
		int iresult=10/3,irem=10%3;
		double dresult=10.0/3.0,drem=10.0%3.0;												Result And Reminder Of int 10/3 : 3    1
		
		Console.WriteLine("Result And Reminder Of int 10/3 : "+iresult+"\t"+irem);			Result And Reminder Of double 10/3 : 3.33333333333333    1
		Console.WriteLine("Result And Reminder Of double 10/3 : "+dresult+"\t"+drem);
	}

}

public class Program																					// Output
{
	public static void Main()												Series Generated By y= x + x++;			Series Generated By y= x + ++x;
	{
		int i,x=1,y;																2										3
		Console.WriteLine("Series Generated By y= x + x++;\n");						4										5	
		for(i=1;i<=10;i++)															6										7	
		{																			8										9			
			y=x + x++;																10										11
			Console.WriteLine(""+y);												12										13
		}																			14										15
		Console.WriteLine("Series Generated By y= x + ++x;\n");						16										17
		x=1;																		18										19
		for(i=1;i<=10;i++)															20										21
		{
			y=x + ++x;
			Console.WriteLine(""+y);
		}
	}
}

public class Program																				//Output
{
	public static void Main()															num is : 1
	{																					num after turning off bit zero: 0			
		ushort num,i;
		for(i=1;i<=10;i++)																num is : 2			
		{																				num after turning off bit zero: 0	
			num=i;																											Like-Wise Upto 10
			Console.WriteLine("num is : "+num);											num is : 3
			num=(ushort) (num & 0xfffe);  // num & 1111 1110	  						num after turning off bit zero: 1
			Console.WriteLine("num after turning off bit zero: " +num +"\n");
		}																				num is : 4
	}																					num after turning off bit zero: 1	
																					
public class Program
{
	public static void Main()
	{																								//Output
		ushort num;
		num=10;																						This Is Odd
			if((num&1)==1)
				Console.WriteLine("This won't executed");
		num=11;
			if((num&1)==1)
				Console.WriteLine("This Is Odd");
	}
}

public class Program
{
	public static void Main()
	{
		int t,val;																					//Output
		val=123;
		for(t=128;t>0;t=t/2)																		01111011
		{
			if((t&val)!=0)
				Console.Write("1");
			if((t&val)==0)
				Console.Write("0");
		}
	}
}

public class Program
{
	public static void Main()																		//Output
	{
		int val=1;																			 0  0  0  0  0  0  0  1 
		for(int i=1;i<=8;i++)																 0  0  0  0  0  0  1  0 
		{																					 0  0  0  0  0  1  0  0 
			for(int t=128;t>0;t=t/2)														 0  0  0  0  1  0  0  0 
			{																				 0  0  0  1  0  0  0  0 
				if((t&val)==0) Console.Write(" 0 ");										 0  0  1  0  0  0  0  0 
				if((t&val)!=0) Console.Write(" 1 ");										 0  1  0  0  0  0  0  0 
			}																				 1  0  0  0  0  0  0  0 
			Console.WriteLine();
			val=val<<1;  //Multiply by 2
		}
	}
}

public class Program
{
	public static void Main()
	{
		int n=10;
			Console.WriteLine("Value Of n is : "+n); 												//Output
		Console.WriteLine();
		n=n<<1;  //Multiply by 2															Value Of n is : 10
			Console.WriteLine("n is Multiply by 2 is "+n);
		n=n>>1;																				n is Multiply by 2 is 20
			Console.WriteLine();
			Console.WriteLine("n is Divide by 2 is "+n);									n is Divide by 2 is 10
	}
}