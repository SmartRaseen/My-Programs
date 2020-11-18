using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
	public int id;
	public string name;
	public int teacherID;
}

public class Teacher
{
	public int teacherID;		
	public string teacherName;	
	
	public Teacher(int id, string name)
	{
		this.teacherID = id;
		this.teacherName = name; 
	}
}

public class Solution
{
	public static void Main()
	{
		var teacher = new List<Teacher>
		{
			new Teacher(1,"nandha"),
			new Teacher(2,"karthik")
		};
		
		Student[] std = {
			new Student() {id = 1,name = "Hameed",teacherID = 1},
			new Student() {id = 2,name = "Raseen",teacherID = 1},
			new Student() {id = 3,name = "Yasin",teacherID = 2},
			new Student() {id = 4,name = "Kriston",teacherID = 2},
		};
		
		
		var innerResult = std.Join(
							teacher,
							teacherData => teacherData.teacherID,
							studentData => studentData.teacherID,
							(studentData,teacherData) => new 
							{ 
								teacherID = teacherData.teacherID,
								teacherName = teacherData.teacherName,
								id = studentData.id,
								name = studentData.name
								});
		
		foreach(var obj in innerResult)
			Console.WriteLine("TeacherID : {0} | TeacherName : {1} | StudentID : {2} | StudentName : {3}",obj.teacherID,obj.teacherName.PadRight(10),obj.id,obj.name);
	
	}
}


using Query
***********

using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
	public int id;
	public string name;
	public int teacherID;
}

public class Teacher
{
	public int teacherID;		
	public string teacherName;	
	
	public Teacher(int id, string name)
	{
		this.teacherID = id;
		this.teacherName = name; 
	}
}

public class Solution
{
	public static void Main()
	{
		var teacher = new List<Teacher>
		{
			new Teacher(1,"nandha"),
			new Teacher(2,"karthik")
		};
		
		Student[] std = {
			new Student() {id = 1,name = "Hameed",teacherID = 1},
			new Student() {id = 2,name = "Raseen",teacherID = 1},
			new Student() {id = 3,name = "Yasin",teacherID = 1},
			new Student() {id = 4,name = "Kriston",teacherID = 2},
			new Student() {id = 5,name = "Srikanth",teacherID = 2}
		};
		
		
		/*var innerResult = std.Join(
							teacher,
							teacherData => teacherData.teacherID,
							studentData => studentData.teacherID,
							(studentData,teacherData) => new 
							{ 
								teacherID = teacherData.teacherID,
								teacherName = teacherData.teacherName,
								id = studentData.id,
								name = studentData.name
								});*/
		
		var innerJoin = from studentData in std
						join teacherData in teacher on studentData.teacherID equals teacherData.teacherID
						select new {teacherID = teacherData.teacherID, teacherName = teacherData.teacherName,
								   id = studentData.id, name = studentData.name};
		
			
		
		foreach(var obj in innerJoin)
			Console.WriteLine("TeacherID : {0} | TeacherName : {1} | StudentID : {2} | StudentName : {3}",obj.teacherID,obj.teacherName.PadRight(10),obj.id,obj.name);
	
	}
}


	Output :
	********

	TeacherID : 1 | TeacherName : nandha     | StudentID : 1 | StudentName : Hameed
	TeacherID : 1 | TeacherName : nandha     | StudentID : 2 | StudentName : Raseen
	TeacherID : 1 | TeacherName : nandha     | StudentID : 3 | StudentName : Yasin
	TeacherID : 2 | TeacherName : karthik    | StudentID : 4 | StudentName : Kriston
	TeacherID : 2 | TeacherName : karthik    | StudentID : 5 | StudentName : Srikanth
	
--------------------------------------------------------------------------------------------------------------------------------------------------------------

