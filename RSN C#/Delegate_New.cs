	Delegate Syntax:
		
	<access modifier> delegate <return type> <delegate_name>(<parameters>)

	Example: Declare delegate
	public delegate void Print(int value);
	
----------------------------------------------------------------------------------------------------------------------------------------------------------
	
	Example Code :
	
	using System;
	
	public delegate void Print(int num); 						// declare delegate
	public delegate void MoneyTransfer(double salary);			// declare delegate

	public class Program
	{
		public static void Main()
		{
			Print PrintDel = PrintDelegate;						// Print delegate points to PrintNumber
			PrintDel(100);
			PrintDel(20000);
		
			MoneyTransfer money = Money;						// MoneyTransfer delegate points to Money
			money(22500.00);
			money(25000.00);
		}
	
		public static void PrintDelegate(int num)
		{
			Console.WriteLine("\n Number : {0}",num);
		}
	
		public static void Money(double money)
		{
			Console.WriteLine("\n Money : {0:C}",money);
		}
	}

	Output : 
	
	Number : 100

	Number : 20000

	Money  : $22,500.00

	Money  : $25,000.00

----------------------------------------------------------------------------------------------------------------------------------------------------------

	using System;

	public delegate void EmployeeID(int id);
	public delegate void SalaryCredited(int salary);

	public class Solution
	{
		public static void Main(string[] args)	
		{
			EmployeeID id = new EmployeeID(PrintEmployeeID);			// You can use like that also for invoking that method name. 
			id.Invoke(26);												// You can use like that also for invoking that value. 
			id(22);
		
			SalaryCredited money = TransferMoney;
			money(10000);
			money(22200);
		}
	
		public static void PrintEmployeeID(int id)
		{
			Console.WriteLine("\n Employee ID : {0}",id);
		}
	
		public static void TransferMoney(int money)
		{
			Console.WriteLine("\n Employee Salary : {0:C}",money);
		}
	}
	
	Output : 
	
	Employee ID : 26

	Employee ID : 22

	Employee Salary : $10,000.00

	Employee Salary : $22,200.00
	
----------------------------------------------------------------------------------------------------------------------------------------------------------

	using System;

	public delegate void Print(int value);

	public class Solution
	{
		public static void Main()
		{
			PrintEmployeeID(ShowEmployeeID,123);
			PrintEmployeeID(TransferMoney,22200);
		}
	
		public static void PrintEmployeeID(Print EmployeeID,int value)
		{
			EmployeeID(value);
		}
	
		public static void ShowEmployeeID(int value)
		{
			Console.WriteLine("EmployeeID : "+value);
		}
	
		public static void TransferMoney(int value)
		{
			Console.WriteLine("Transfered Money : {0:C}",value);
		}
	}
