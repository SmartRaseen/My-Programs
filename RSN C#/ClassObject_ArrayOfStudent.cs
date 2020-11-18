	
	Student objects from an array of Students 
	*****************************************
	
	
	Before C# 2.0, we had to use a 'foreach' or a 'for' loop to traverse the collection to find a particular object. 
	
	For example, we had to write the following code to find all Student objects from an array of Students 
	where the age is between 12 and 20 (for teenage 13 to 19):
	
	using System;
	
	class Student
	{
		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }
	}
	
	public class Program
	{
		public static void Main(string[] args)
		{
			Student[] studentArray = { 
				new Student() { StudentID = 1, StudentName = "John", Age = 18 },
				new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
				new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
				new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
			};
	
			Student[] students = new Student[10];
	
			int i = 0;
	
			foreach (Student std in studentArray)
			{
				if (std.Age > 12 && std.Age < 20)
				{
					students[i] = std;
					Console.WriteLine("\n Student ID : {0}",students[i].StudentID);
					Console.WriteLine("\n Student Name : {0}",students[i].StudentName);
					Console.WriteLine("\n Student Age : {0}",students[i].Age);
					i++;
					Console.WriteLine("\n ****************************************");
				}
			}
		}
	}
	
-----------------------------------------------------------------------------------------------------------------------------------------------------------------
	
	Output :
	********
	
	
	Student ID : 1
	
	Student Name : John
	
	Student Age : 18
	
	****************************************
	
	Student ID : 6
	
	Student Name : Chris
	
	Student Age : 17
	
	****************************************
	
	Student ID : 7
	
	Student Name : Rob
	
	Student Age : 19
	
	****************************************