

	Linq using Distinct
	*******************

	using System;
	using System.Linq;					
	using System.Collections.Generic;
	
	public class Program
	{
		public static void Main(string[] args)
		{
			List<string> strList = new List<string>()
			{
				"One",
				"Two",
				"Three",
				"One",
				"Two"
			};
			
			List<int> intList = new List<int>()
			{ 1,2,3,2,1,4,3,4,5,5};
			
			var distinctStr = strList.Distinct();
			
			foreach(var strData in distinctStr)
				Console.WriteLine("{0}",strData);
			
			var distinctInt = intList.Distinct();
			
			foreach(var IntData in distinctInt)
				Console.WriteLine("{0}",IntData);
		}
	}
	
	Output :
	********
	
	One
	Two
	Three
	1
	2
	3
	4
	5
	
---------------------------------------------------------------------------------------------------------------------------------------------------------------

	Distinct()	-	(Extension Method)
	**********      ******************
	
	
	using System;
	using System.Linq;
	using System.Collections.Generic;
	
	
	public class Program
	{
		public static void Main()
		{
			IList<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
				new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
			};
	
	
			var distinctStudents = studentList.Distinct(new StudentComparer());
	
			foreach (var std in distinctStudents)
				Console.WriteLine(std.StudentName);
	
		}
	}
	
	public class Student
	{
		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }
	}
	
	public class StudentComparer : IEqualityComparer<Student>
	{
		public bool Equals(Student x, Student y)
		{
			if (x.StudentID == y.StudentID
					&& x.StudentName.ToLower() == y.StudentName.ToLower())
				return true;
	
			return false;
		}
	
		public int GetHashCode(Student obj)
		{
			return obj.StudentID.GetHashCode();
		}
	}
	
	Output :
	********
	
	John
	Steve
	Bill
	Ron
	
---------------------------------------------------------------------------------------------------------------------------------------------------------------


	Union In Linq
	*************
	
	using System;
	using System.Linq;					
	using System.Collections.Generic;
	
	
	public class Program
	{
		public static void Main()
		{
			IList<string> Student = new List<string>() { 
				"Hameed","Raseen"
			};
			
			List<string> Teacher = new List<string>()
			{
				"Karthik","Nandha"
			};
	
			var unionData = Student.Union(Teacher);
			
			foreach(var std in unionData)
				Console.WriteLine(std);
		}
	}

	Output:
	
	Hameed
	Raseen
	Karthik
	Nandha
	
---------------------------------------------------------------------------------------------------------------------------------------------------------------

	Intersect in Linq
	*****************
	
	using System;
	using System.Linq;					
	using System.Collections.Generic;


	public class Program
	{
		public static void Main()
		{
			IList<string> Student = new List<string>() { 
				"Hameed","Raseen","Karthik"
			};
			
			List<string> Teacher = new List<string>()
			{
				"Karthik","Nandha"
			};
	
			var unionData = Student.Intersect(Teacher);
			
			foreach(var std in unionData)
				Console.WriteLine(std);
		}
	}
	
	Output : 
	********
	
	Karthik
	
---------------------------------------------------------------------------------------------------------------------------------------------------------------

	Using Except in Linq
	********************
	
	using System;
	using System.Linq;					
	using System.Collections.Generic;
	
	
	public class Program
	{
		public static void Main()
		{
			IList<string> Student = new List<string>() { 
				"Hameed","Raseen","Karthik"
			};
			
			List<string> Teacher = new List<string>()
			{
				"Karthik","Nandha"
			};
	
			var unionData = Student.Except(Teacher);
			
			foreach(var std in unionData)
				Console.WriteLine(std);
		}
	}
	
	Output : 
	*********
	
	Hameed
	Raseen

---------------------------------------------------------------------------------------------------------------------------------------------------------------


