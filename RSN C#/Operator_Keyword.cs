
	Opearator Keyword
	*****************
	
	C# | as Operator Keyword
	
	*	The ‘as’ operator keyword in C# is used only for nullable, reference and boxing conversions. 
	*	It can’t perform user-defined conversions that can be only performed by using cast expression.
	
	Example 1: 
		
	*	In the below code, name contains a string which is assigned to a variable obj1 of the object type. 
	
	*	Now, this obj1 is cast to string using as operator.
	
	
	Example Code : 
	**************
	
	using System;
					
	public class Program
	{
		public static void Main()
		{
			string name = "Abubakkar Siddique";
			object obj = name;
			Console.WriteLine("Sahaba name 1 : {0} ",name);
			Console.WriteLine("Favourite sahaba of prophet : {0} ",name);
			string str2 = obj as string;
			if(str2!=null)
				Console.WriteLine("First sahaba who got the name for the heaven : {0}",str2);
		}
	}
	
---------------------------------------------------------------------------------------------------------------------------------------------------------------
		
	C# | is Operator Keyword
		
	*	The line of code Example if(player is Player) is used to check whether player(object of class Player) is of type Player. 
	
	*	It will return true as player is the instance of Player class. 
	
	*	But next time player assign null so instance null is not of type Player, that’s why it returns false.
	
	Example Code : 
	**************

	using System;
		
	public class Player	
	{
		public void GetPlayerNameList(string players)
		{
			Console.WriteLine("\n Player Name : {0}",players);
		}
	}

	public class Program
	{
		public static void Main()
		{
			var player = new Player();
		
			if(player is Player)
			{
				bool value = player is Player;
				Console.WriteLine("\n Player Class Obj player is : {0}",value);
				for(int i=0;i<3;i++)
				{
					string[] str = {"Raseen","Rohit","Dhoni"};
					player.GetPlayerNameList(str[i]);
				}
			}		
		
			player = null;
		
			bool result = player is Player;
		
			if(result == false)
			{
				Console.WriteLine("\n Result For Player Class Object player is : {0}",result);
				Console.WriteLine("\n So It Can't Print The Players Names");
			}
		}
	}
	
	Output :
	********
	
	Player Class Obj player is : True

	Player Name : Raseen

	Player Name : Rohit

	Player Name : Dhoni

	Result For Player Class Object player is : False

	So It Can't Print The Players Names

---------------------------------------------------------------------------------------------------------------------------------------------------------------

	C# | sizeof Operator Keyword
	****************************
		
	*	It is a compile time unary operator which can be used to compute the size of its operand.	
	
	Example Code :
		
	using System;
					
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("SizeOf Byte".PadRight(15)+": {0}",sizeof(byte));
			Console.WriteLine("SizeOf Short".PadRight(15)+": {0}",sizeof(short));
			Console.WriteLine("SizeOf Char".PadRight(15)+": {0}",sizeof(char));
			Console.WriteLine("SizeOf Int".PadRight(15)+": {0}",sizeof(int));
			Console.WriteLine("SizeOf Float".PadRight(15)+": {0}",sizeof(float));
			Console.WriteLine("SizeOf Long".PadRight(15)+": {0}",sizeof(long));
			Console.WriteLine("SizeOf Double".PadRight(15)+": {0}",sizeof(double));
			Console.WriteLine("SizeOf Decimal".PadRight(15)+": {0}",sizeof(decimal));
		}
	}
	
	
	Output:
	*******
	
	SizeOf Byte    : 1
	SizeOf Short   : 2
	SizeOf Char    : 2
	SizeOf Int     : 4
	SizeOf Float   : 4
	SizeOf Long    : 8
	SizeOf Double  : 8
	SizeOf Decimal : 16
	
---------------------------------------------------------------------------------------------------------------------------------------------------------------

	using System;
					
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("SizeOf Byte".PadRight(15)+": {0}",typeof(byte));
			Console.WriteLine("SizeOf Short".PadRight(15)+": {0}",typeof(short));
			Console.WriteLine("SizeOf Char".PadRight(15)+": {0}",typeof(char));
			Console.WriteLine("SizeOf Int".PadRight(15)+": {0}",typeof(int));
			Console.WriteLine("SizeOf Float".PadRight(15)+": {0}",typeof(float));
			Console.WriteLine("SizeOf Long".PadRight(15)+": {0}",typeof(long));
			Console.WriteLine("SizeOf Double".PadRight(15)+": {0}",typeof(double));
			Console.WriteLine("SizeOf Decimal".PadRight(15)+": {0}",typeof(decimal));
		}
	}

	Output:
	*******
	
	SizeOf Byte    : System.Byte
	SizeOf Short   : System.Int16
	SizeOf Char    : System.Char
	SizeOf Int     : System.Int32
	SizeOf Float   : System.Single
	SizeOf Long    : System.Int64
	SizeOf Double  : System.Double
	SizeOf Decimal : System.Decimal

