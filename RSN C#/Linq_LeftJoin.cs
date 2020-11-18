
	LeftJoin
	********

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
			new Student() {id = 1,name = "Hameed",teacherID = 3},
			new Student() {id = 2,name = "Raseen",teacherID = 3},
			new Student() {id = 3,name = "Yasin",teacherID = 3},
			new Student() {id = 4,name = "Kriston",teacherID = 4},
			new Student() {id = 5,name = "Srikanth",teacherID = 4}
		};
		
		var leftJoin = from studentData in std
						join teacherData in teacher on studentData.teacherID equals teacherData.teacherID into teacherGroup
						select teacherGroup.DefaultIfEmpty(new Teacher(studentData.teacherID,"Nothing!"));
		
		   // Store the count of total items (for demonstration only).
           int totalItems = 0;

           Console.WriteLine("\n Left Outer Join:");

           // A nested foreach statement  is required to access group items
           foreach (var prodGrouping in leftJoin)
           {
               Console.WriteLine("\n Group:");
               foreach (var obj in prodGrouping)
               {
                   totalItems++;
                   Console.WriteLine("\n TeacherID : {0} | TeacherName : {1} ",obj.teacherID,obj.teacherName.PadRight(10));
               }
           }
		Console.WriteLine("\n LeftOuterJoin: {0} items in {1} groups", totalItems, leftJoin.Count());
		
	}
}


	Output : 
	
	Left Outer Join:

	Group:
	
	TeacherID : 3 | TeacherName : Nothing!   
	
	Group:
	
	TeacherID : 3 | TeacherName : Nothing!   
	
	Group:
	
	TeacherID : 3 | TeacherName : Nothing!   
	
	Group:
	
	TeacherID : 4 | TeacherName : Nothing!   
	
	Group:
	
	TeacherID : 4 | TeacherName : Nothing!   
	
	LeftOuterJoin: 5 items in 5 groups
	
	
----------------------------------------------------------------------------------------------------------------------------------------------------------
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
    private static object studentGroup;

    public static void Main()
    {
        var teacher = new List<Teacher>
        {
            new Teacher(3,"nandha"),
            new Teacher(4,"karthik")
        };

        List<Student> std = new List<Student>
        {
            new Student() {id = 1,name = "Hameed",teacherID = 3},
            new Student() {id = 2,name = "Raseen",teacherID = 3},
            new Student() {id = 3,name = "Yasin",teacherID = 3},
            new Student() {id = 4,name = "Kriston",teacherID = 4},
            new Student() {id = 5,name = "Srikanth",teacherID = 4},
            new Student() {id = 5,name = "new Student",teacherID = 0}
        };

        //var leftJoin = from teacherData in teacher
        //               join studentData in std on teacherData.teacherID equals studentData.teacherID
        //               into stdInfo
        //               from student in stdInfo.DefaultIfEmpty()
        //               select new { teacherData.teacherName, student.id, student.name,teacherData.teacherID};


        var leftJoin = from studentData in std
                       join teacherData in teacher on studentData.teacherID equals teacherData.teacherID
                       into stdInfo
                       from tchr in stdInfo.DefaultIfEmpty()
                       select new { studentData.id, studentData.name, teacherName = tchr==null?"*Teacher not found*":tchr.teacherName};



        // Store the count of total items (for demonstration only).
        int totalItems = 0;

        Console.WriteLine("\n Left Outer Join:");

        // A nested foreach statement  is required to access group items
            foreach (var obj in leftJoin)
            {
                totalItems++;
                Console.WriteLine("\n  StudentID : {1} | StudentName : {2} | TeacherName : {0} ", obj.teacherName, obj.id, obj.name);
            }
        Console.WriteLine("\n **************************************************");
        Console.WriteLine("\n LeftOuterJoin: {0} items in {1} groups", totalItems, leftJoin.Count());
        Console.WriteLine("\n **************************************************");

        Console.ReadLine();
    }
}

	Output :
	
	Left Outer Join:

 	StudentID : 1 | StudentName : Hameed | TeacherName : nandha 
 	
 	StudentID : 2 | StudentName : Raseen | TeacherName : nandha 
 	
 	StudentID : 3 | StudentName : Yasin | TeacherName : nandha 
 	
 	StudentID : 4 | StudentName : Kriston | TeacherName : karthik 
 	
 	StudentID : 5 | StudentName : Srikanth | TeacherName : karthik 
 	
 	StudentID : 5 | StudentName : new Student | TeacherName : *Teacher not found* 
 	
 	*************************************************
 	
 	eftOuterJoin: 6 items in 6 groups
 	
 	*************************************************

----------------------------------------------------------------------------------------------------------------------------------------------------------

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
            new Teacher(3,"nandha"),
            new Teacher(4,"karthik")
        };

        Student[] std = {
            new Student() {id = 1,name = "Hameed",teacherID = 3},
            new Student() {id = 2,name = "Raseen",teacherID = 3},
            new Student() {id = 3,name = "Yasin",teacherID = 3},
            new Student() {id = 4,name = "Kriston",teacherID = 4},
            new Student() {id = 5,name = "Srikanth",teacherID = 4}
        };

        var leftJoin = from teacherData in teacher
                       join studentData in std on teacherData.teacherID equals studentData.teacherID
           into studentGroup
                       select studentGroup.DefaultIfEmpty(new Student() { teacherID = teacherData.teacherID, id = 0, name = "Nothing!" });

        // Store the count of total items (for demonstration only).
        int totalItems = 0;

        Console.WriteLine("\n Left Outer Join:");

        // A nested foreach statement  is required to access group items
        foreach (var prodGrouping in leftJoin)
        {
            Console.WriteLine("\n Group:");
            foreach (var obj in prodGrouping)
            {
                totalItems++;
                Console.WriteLine("\n TeacherID : {0} | StudentID : {1} | StudentName : {2} ", obj.teacherID, obj.id, obj.name);
            }
        }
        Console.WriteLine("\n **************************************************");
        Console.WriteLine("\n LeftOuterJoin: {0} items in {1} groups", totalItems, leftJoin.Count());
        Console.WriteLine("\n **************************************************");

        Console.ReadLine();
    }
}
 
 
 Output :
 ********
 
 Left Outer Join:

 Group:

 TeacherID : 3 | StudentID : 1 | StudentName : Hameed

 TeacherID : 3 | StudentID : 2 | StudentName : Raseen

 TeacherID : 3 | StudentID : 3 | StudentName : Yasin

 Group:

 TeacherID : 4 | StudentID : 4 | StudentName : Kriston

 TeacherID : 4 | StudentID : 5 | StudentName : Srikanth

 **************************************************

 LeftOuterJoin: 5 items in 2 groups

 **************************************************


----------------------------------------------------------------------------------------------------------------------------------------------------------