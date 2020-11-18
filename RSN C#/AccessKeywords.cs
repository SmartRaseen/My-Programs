

	Access Keyword
	**************

	this Keyword
	************
	
	using System;
						
	public class Program
	{
		byte empID;
		string empName;
		double empSalary;
		public static void Main()
		{
			var solution = new Solution(26,"Raseen",25000);
		}
	}
	
	public class Solution
	{
		byte EmpID;
		string EmpName;
		double EmpSalary;
		
		public Solution(byte id,string name, double salary)
		{
			this.EmpID = id;
			this.EmpName = name;
			this.EmpSalary = salary;
			
			Console.WriteLine("\n Employee ID : "+this.EmpID);
			Console.WriteLine("\n Employee Name : "+this.EmpName);
			Console.WriteLine("\n Employee Salay : "+this.EmpSalary);
		}
	}
