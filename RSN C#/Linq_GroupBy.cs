

	Linq Using GroupBy
	******************

	Example : Code
	**************

	using System;
	using System.Linq;
	using System.Collections.Generic;
	
	public class Student{
	
		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }	
	}
	
	public class Solution
	{
		public static void Main(string[] args)
		{
			List<Student> myItems = new List<Student>()
			{
				new Student() {StudentID = 1,StudentName = "Janarthanam",Age = 22},
				new Student() {StudentID = 2,StudentName = "Raseen",Age = 22},
				new Student() {StudentID = 3,StudentName = "Geetha",Age = 23},
				new Student() {StudentID = 4,StudentName = "Ayisha",Age = 21},
				new Student() {StudentID = 5,StudentName = "Ajma",Age = 21},
				new Student() {StudentID = 6,StudentName = "Benazir",Age = 20},
				new Student() {StudentID = 7,StudentName = "Ameer",Age = 22},
				new Student() {StudentID = 8,StudentName = "Fathima",Age = 20},
				new Student() {StudentID = 9,StudentName = "Kiruthiga",Age = 23},
				new Student() {StudentID = 10,StudentName = "Rizvan",Age = 22}
			};
			
			var groupedResult = from name in myItems
								group name by name.Age;
								
							(or)	Both are same one
								
			var groupedResult = studentList.GroupBy(s => s.Age);
			
			foreach(var result in groupedResult)
			{
				Console.WriteLine("\n Age Group : {0}",result.Key);	//Each group has a key
				Console.WriteLine(" **************");
				
				foreach(Student std in result)
					Console.WriteLine("\n ID : {0} | Name : {1}",std.StudentID,std.StudentName);	// Each group has inner collection
			}
		}
	}
	
	ToLookup
	********
	
	*	ToLookup is the same as GroupBy; the only difference is GroupBy execution is deferred, 
		whereas ToLookup execution is immediate. 
	
	*	Also, ToLookup is only applicable in Method syntax. ToLookup is not supported in the query syntax.
	
	var lookupResult = studentList.ToLookUp(s=> s.Age);
	
	Same as Output
	--------------

---------------------------------------------------------------------------------------------------------------------------------------------------------------

	Output : 
	
	Age Group : 22
	**************
	
	ID : 1 | Name : Janarthanam
	
	ID : 2 | Name : Raseen
	
	ID : 7 | Name : Ameer
	
	ID : 10 | Name : Rizvan
	
	Age Group : 23
	**************
	
	ID : 3 | Name : Geetha
	
	ID : 9 | Name : Kiruthiga
	
	Age Group : 21
	**************
	
	ID : 4 | Name : Ayisha
	
	ID : 5 | Name : Ajma
	
	Age Group : 20
	**************
	
	ID : 6 | Name : Benazir
	
	ID : 8 | Name : Fathima
