

	Linq
	****
		
	*	LINQ (Language Integrated Query) is uniform query syntax in C# and VB.NET to retrieve data from different sources and formats.
	
	*	For example, SQL is a Structured Query Language used to save and retrieve data from a database. 
	
	*	In the same way, LINQ is a structured query syntax built in C# and VB.NET to retrieve data 
		from different types of data sources such as collections, ADO.Net DataSet, XML Docs, web service and MS SQL Server and other databases.
	
	*	The following example demonstrates a simple LINQ query that gets all strings from an array which contains 'a'.
	
	
	
	Linq Operations
	***************
	
	*	var queryLondonCustomers = from cust in customers
                           where cust.City == "London"
                           select cust;
						   
	*	where cust.City=="London" && cust.Name == "Devon"
	
	*	where cust.City == "London" || cust.City == "Paris"
	
	*	Ordering - (Sample Code)
	
	*	var queryLondonCustomers3 = from cust in customers
								where cust.City == "London"
								orderby cust.Name ascending
								select cust;
	
------------------------------------------------------------------------------------------------------------------------------------------------------------------	
	
	Example : Code For Query Syntax
	*******************************
	
	using System;
	using System.Collections.Generic;
	using System.Linq;
						
	public class Program
	{
		public static void Main()
		{
			List<string> myList = new List<string>()
			{
				"VueData",
				"TCS",
				"CTS",
				"Wipro",
				"Infosys"
			};
			
			var compList = from name in myList
							where name.Contains("V")
							select name;
			
			foreach(var myComp in compList)
				Console.WriteLine(myComp);
			
		}
	}

	Output :
	
	VueData
	
------------------------------------------------------------------------------------------------------------------------------------------------------------------	
	
	Example Code :
	**************
	
	using System;
	using System.IO;
	using System.Linq;
	
	public class Solution
	{
		public static void Main(string[] args)
		{
			string[] names = {"Raseen","Hameed","Sulthan","Yasin","Ameer"};
			
			var myLinqName = from name in names
								where name.Contains("a")
								select name;
			
			foreach(var myLinq in myLinqName)
				Console.WriteLine(myLinq);
						
		}
	}

------------------------------------------------------------------------------------------------------------------------------------------------------------------
	
	*	Use of for loop is cumbersome, not maintainable and readable. C# 2.0 introduced delegate, 
		which can be used to handle this kind of a scenario, as shown below.

		Example: Use Delegates to Find Elements from the Collection in C# 2.0
	
	Example Code :
	**************
	
	using System;

	delegate bool FindStudent(Student std);
	
	public class Student
	{
		public int employeeID;
		public string employeeName;
		public double employeeSalary;
	}
	
	class StudentExtension
	{
		public static Student[] where(Student[] studentArray, FindStudent del)
		{
			Student[] result = new Student[studentArray.Length];
			int i=0;
			foreach(Student std in studentArray)
			{	
				if(del(std))
				{
					result[i] = std;
					i++;
					Console.WriteLine("EmployeeID : {0} | EmployeeName : {1} | EmployeeSalary : {2}",std.employeeID,std.employeeName.PadRight(8),std.employeeSalary);
				}
			}
			return result;
		}
	}
	
	public class Program
	{	
		public static void Main(string[] args)
		{
			Student[] studentList = {	
				new Student() {employeeID = 1,employeeName = "Raseen", employeeSalary = 80000 },
				new Student() {employeeID = 2,employeeName = "Ameer", employeeSalary = 60000 },
				new Student() {employeeID = 3,employeeName = "Afridi", employeeSalary = 50000 },
				new Student() {employeeID = 4,employeeName = "Basith", employeeSalary = 70000 },
				new Student() {employeeID = 5,employeeName = "Yasin", employeeSalary = 75000 }
			};
			
			Student[] stud = StudentExtension.where(studentList,delegate(Student std)
			{
				return std.employeeSalary > 50000;
			});
		}
	}
	
	Output :
	********
	
	EmployeeID : 1 | EmployeeName : Raseen   | EmployeeSalary : 80000
	EmployeeID : 2 | EmployeeName : Ameer    | EmployeeSalary : 60000
	EmployeeID : 4 | EmployeeName : Basith   | EmployeeSalary : 70000
	EmployeeID : 5 | EmployeeName : Yasin    | EmployeeSalary : 75000
	
------------------------------------------------------------------------------------------------------------------------------------------------------------------

	Linq using Where Condition
	**************************
	
	*	Example : Code
		**************
		
		using System;
		using System.Collections.Generic;
		using System.Linq;
		
		public class Student
		{
			public short id;
			public string name;
			public short age;
		}
		
		public class Solution
		{
			public static void Main()
			{		
				List<Student> studentDetails = new List<Student>()
				{
					new Student() {id=1,name="Yasin",age =22 },
					new Student() {id=2,name="Raseen",age =22},
					new Student() {id=3,name="Hameed",age =22 },
					new Student() {id=4,name="Ayisha",age =20 },
					new Student() {id=5,name="Ajma",age =21 },
					new Student() {id=6,name="Benazir",age =18 }
				};
				
				// LINQ Query Method to find out teenager students
				var student = studentDetails.Where(s => s.age > 18 && s.age < 22);
				
				foreach(Student std in student)
					Console.WriteLine(std.name);
				
				Console.WriteLine("\n");
					
				//------------------------------------------------------------------------------------------------------------------
				
				var myComp = from stud in studentDetails
								orderby stud.name ascending
								where stud.age >16 && stud.age<23
								where stud.name =="Raseen" || stud.name == "Ajma"
								select stud;
				
				foreach(var company in myComp)
					Console.WriteLine("ID : {0} | Name : {1} | Age : {2}",company.id,company.name.PadRight(8),company.age);
					
				Console.WriteLine("\n");

				//------------------------------------------------------------------------------------------------------------------
				
				var filteredResult = studentDetails.Where((s, i) => { 
							if(i % 2 ==  0) // if it is even element
								return true;
																
								return false;
							});

				foreach (var std in filteredResult)
					Console.WriteLine("ID : {0} Name : {1} Age : {2}",std.id,std.name,std.age);
		
				Console.WriteLine("\n");
				
				//------------------------------------------------------------------------------------------------------------------
			}
		}
		
	Output :
	********
	
	Ayisha
	Ajma
	
	Output :
	********
	
	ID : 5 | Name : Ajma     | Age : 21
	ID : 2 | Name : Raseen   | Age : 22
	
	Output :
	********
	
	ID : 1 Name : Yasin 	Age	: 22
	ID : 3 Name : Hameed 	Age	: 22
	ID : 5 Name : Ajma 		Age	: 21

------------------------------------------------------------------------------------------------------------------------------------------------------------------

	LINQ query with lambda expression 
	*********************************
	
	*	The example below shows how you can use LINQ query with lambda expression to find a particular student(s) from the student collection.
	
	Example Code :
	**************
	
	
