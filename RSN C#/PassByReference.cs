
	Pass by Reference
	*****************

*	When you pass a reference type variable from one method to another, 
	it doesn't create a new copy; instead, it passes the address of the variable. 

*	If we now change the value of the variable in a method, it will also be reflected in the calling method.


Example Code :

using System;
public class Student{

	public string StudentName { get; set; }
	
}

public class Program
{
	public static void ChangeReferenceType(Student std2)
	{
		std2.StudentName   = "Steve";
	}
	
	public static void Main()
	{
		Student std1 = new Student();
		
		std1.StudentName = "Bill";
		
		ChangeReferenceType(std1);
	
		Console.WriteLine(std1.StudentName);
	}
}
----------------------------------------------------------------------------------------------------------------------------------------
using System;
		
public class Student
{
	public string StudentName {get;set;}
}

public class Program
{
	public static void Main()
	{
		var std = new Student();
		
		std.StudentName = "Bill";
		
		Console.WriteLine("Student Name Before : "+std.StudentName);
		
		ChangeStudent(std);
		
		Console.WriteLine("Student Name After : "+std.StudentName);
	}
	public static void ChangeStudent(Student std)
	{
		std.StudentName = "Raseen";
	}
}



