using System;
using System.Collections.Generic;

public class rsn
{
	public static void Main()
	{
		List<Student> student = new List<Student>()
		{
			new Student(){ID = 1,Name = "Raseen"},
			new Student(){ID = 2,Name = "Hameed"},
			new Student(){ID = 3,Name = "Sulthan"},
			new Student(){ID = 4,Name = "Geetha"},
		};
		
		Console.WriteLine("\n Original List \n");
		
		foreach(var stud in student)
			Console.WriteLine("Student ID : {0} : Student Name : {1}",stud.ID,stud.Name);
		
		Console.WriteLine("\n After change the name... \n");
			
		int i=0;

	foreach (Student s in student)
	{
		i++;
    	if (s.ID == i)
        	s.ID = i+4; // I found a match and I want to edit the item at this index
	}

		foreach(var stud in student)
			Console.WriteLine("Student ID : {0} : Student Name : {1}",stud.ID,stud.Name);
	}
}

public class Student
{
	public int ID;
	public string Name;
}