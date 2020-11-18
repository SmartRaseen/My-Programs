	Access Protected Modifier
	*************************
	
	*	The Protected modifier allows codes in the same class or a class that derives from that class to access the type or its members.
	
	Example Code : 
	**************
	
	using System;

	public class Program
	{
		protected static byte ID;
		protected static string Name;
	
		public static void Main()
		{
		
			ID = 26;
			Name = "Raseen";
			Console.WriteLine("\n Employee ID : {0} Name : {1} ",ID,Name);
			var rsn = new RSN();
			rsn.DataWritter();
		}	
	}

	public class RSN : Program
	{
		public void DataWritter()
		{
			ID = 5;
			Name = "Hameed";
			Console.WriteLine("\n Employee ID : {0} Name : {1}",ID,Name);
		}
	}

	Output :
	********
	
	Employee ID : 26 Name : Raseen
	
	Employee ID : 5 Name : Hameed

----------------------------------------------------------------------------------------------------------------------------------------------------------------	

	Access Public Modifier
	**********************
	
	*	The Public modifier allows any part of the program in the same assembly or another assembly to access the type and its members.
	
	Example Code : 
	**************
	
	using System;

	public class Program
	{
		public static byte ID;
		public static string Name;
	
		public static void Main()
		{
			ID = 26;
			Name = "Raseen";
			Console.WriteLine("\n Employee ID : {0} Name : {1} ",ID,Name);
			var rsn = new RSN();
			rsn.DataWritter();
		}
	}

	public class RSN : Program
	{
		public void DataWritter()
		{
			ID = 5;
			Name = "Hameed";
			Console.WriteLine("\n Employee ID : {0} Name : {1}",ID,Name);
		}
	}

	Another way

	public void DataWritter()
	{
		var prog = new Program();
		prog.ID = 5;
		prog.Name = "Hameed";
		Console.WriteLine("\n Employee ID : {0} Name : {1}",prog.ID,prog.Name);
	}
	
----------------------------------------------------------------------------------------------------------------------------------------------------------------	

	Access Private Modifier
	***********************
	
	*	The Private modifier restricts other parts of the program from accessing the type and its members. 
	
	*	Only code in the same class or struct can access it.
	
	
	using System;

	public class Program
	{
		private byte ID;
		private string Name;
	
		public static void Main()
		{
			var program = new Program();
			prograam.ID = 26;
			program.Name = "Raseen";
			Console.WriteLine("\n Employee ID : {0} Name : {1} ",program.ID,program.Name);	
		}
	}
	
----------------------------------------------------------------------------------------------------------------------------------------------------------------	

	Access Internal Modifier
	************************
		
	*	The Internal modifier allows other program code in the same assembly to access the type or its members. 
	
	*	This is default access modifiers if no modifier is specified.	
	
	* 	Its also same like protected if you want to access derived from that class.
	
	using System;

	public class Program
	{
		internal byte productID;
		internal short productCost;
		internal string productName;
		internal short productQuantity;
		
		public static void Main()
		{
			var prog = new Program();
			prog.DataHolder();
			Console.WriteLine("\n ************************");
			prog.DataMaintainer();
			Console.WriteLine("\n ************************");
			var rasee = new rsn();
			rasee.CloningData();
		}
	
		public void DataHolder()
		{
			productID = 1;
			productName = "Dell";
			productCost = 25000; 
			productQuantity = 500;
			Console.WriteLine("\n ProductID = {0,-12:N0}",productID);
			Console.WriteLine("\n ProductName = {0}",productName);
			Console.WriteLine("\n ProductCost = {0:C}",productCost);
			Console.WriteLine("\n productQuantity = {0,-12:N0}",productQuantity);
		}
	
		public void DataMaintainer()
		{
			productID = 2;
			productName = "Oppo";
			productCost = 15000; 
			productQuantity = 1500;
			Console.WriteLine("\n ProductID = {0,-12:N0}",productID);
			Console.WriteLine("\n ProductName = {0}",productName);
			Console.WriteLine("\n ProductCost = {0:C}",productCost);
			Console.WriteLine("\n productQuantity = {0,-12:N0}",productQuantity);
		}	
	}

	public class rsn : Program
	{
		public void CloningData()
		{
			productID = 3;
			productName = "Watch";
			productCost = 5000;
			productQuantity = 2000;
		
			Console.WriteLine("\n ProductID = {0,-12:N0}",productID);
			Console.WriteLine("\n ProductName = {0}",productName);
			Console.WriteLine("\n ProductCost = {0:C}",productCost);
			Console.WriteLine("\n productQuantity = {0,-12:N0}",productQuantity);
		}
	}	

----------------------------------------------------------------------------------------------------------------------------------------------------------------	
