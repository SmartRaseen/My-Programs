using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		IDictionary<int, string> dict = new Dictionary<int, string>();
		dict.Add(1,"One");
		dict.Add(2,"Two");
		dict.Add(3,"Three");
		
		Console.WriteLine(dict.Count);
		
	}
}

output

3
---------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		IDictionary<int, string> dict = new Dictionary<int, string>();

		dict.Add(new KeyValuePair<int, string>(1, "One"));
		dict.Add(new KeyValuePair<int, string>(2, "Two"));		
		
		dict.Add(3, "Three");
		dict.Add(100, "Hundred");
		
		Console.WriteLine(dict.Count);
		
	}
}

output

4
---------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		IDictionary<int, string> dict = new Dictionary<int, string>(){
																		{1,"One"},
																		{2, "Two"},
																		{3,"Three"}
																	};
		
		Console.WriteLine(dict.Count);
		
	}
}

output

3

---------------------------------------------------------------------------------------------------------------------

Example: Access elements using foreach

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Dictionary<int, string> dict = new Dictionary<int, string>()
            {
            {1,"Rohit"},
            {2, "Dhawan"},
            {3,"Virat"},
			{4,"Dhoni"},
            {5, "Raina"},
            {6,"Yuvraj"},
			{7,"Jadeja"},
            {8, "Ashwin"},
            {9,"Bumrah"},
			{10, "Shami"},
            {11,"Chahal"}
            };

		foreach (KeyValuePair<int, string> item in dict)
		{
			Console.WriteLine("Player: {0}, Name: {1}", item.Key, item.Value);
		}
	}
}


output

Player: 1,  Name: Rohit
Player: 2,  Name: Dhawan
Player: 3,  Name: Virat
Player: 4,  Name: Dhoni
Player: 5,  Name: Raina
Player: 6,  Name: Yuvraj
Player: 7,  Name: Jadeja
Player: 8,  Name: Ashwin
Player: 9,  Name: Bumrah
Player: 10,  Name: Shami
Player: 11,  Name: Chahal

---------------------------------------------------------------------------------------------------------------------

Use (For Loop) Like Same

using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Dictionary<int, string> dict = new Dictionary<int, string>()
                                                            {
                                                                {1,"One"},
                                                                {2, "Two"},
                                                                {3,"Three"}
                                                            };


		for (int i = 0; i < dict.Count; i++)
		{
			Console.WriteLine("Key: {0}, Value: {1}", 
													dict.Keys.ElementAt(i), 
													dict[ dict.Keys.ElementAt(i)]);
		}
	}
}

---------------------------------------------------------------------------------------------------------------------

using System;

using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Dictionary<int, string> dict = new Dictionary<int, string>()
        {
        	{1,"One"},
        	{2, "Two"},
        	{3,"Three"}
        };

		Console.WriteLine(dict[1]); 		
		Console.WriteLine(dict[2]);
		string player = dict[3];
		Console.WriteLine(player);
	}
}

output

One
Two
Three

---------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Dictionary<int, string> dict = new Dictionary<int, string>()
                                                            {
                                                                {1,"One"},
                                                                {2, "Two"},
                                                                {3,"Three"}
                                                            };


		Console.WriteLine("Contains 1? {0}",dict.ContainsKey(1)); // returns true
		
		Console.WriteLine("ContainsKey 4? {0}", dict.ContainsKey(4)); // returns false

		Console.WriteLine("Contains Key-Value pair? {0}",dict.Contains(new KeyValuePair<int,string>(1,"One")));
	}
}

output

Contains 1? True
ContainsKey 4? False
Contains Key-Value pair? True

---------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		IDictionary<int, Student> studentDict = new Dictionary<int, Student>()
                    {
                        { 1, new Student(){ StudentID =1, StudentName = "Bill"}},
                        { 2, new Student(){ StudentID =2, StudentName = "Steve"}},
                        { 3, new Student(){ StudentID =3, StudentName = "Ram"}}
                    };

        Student std = new Student(){ StudentID = 1, StudentName = "Bill"};

        KeyValuePair<int, Student> studentToFind = new KeyValuePair<int, Student>(1, std);

        bool result = studentDict.Contains(studentToFind, new StudentDictionaryComparer()); 
		
		if(result == true)
			dict.Remove(1);
    
		Console.WriteLine("Found Student? {0}",result);
	}
}

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
}

class StudentDictionaryComparer : IEqualityComparer<KeyValuePair<int,Student>>
{
    public bool Equals(KeyValuePair<int, Student> x, KeyValuePair<int, Student> y)
    {
        if (x.Key == y.Key && (x.Value.StudentID == y.Value.StudentID) && (x.Value.StudentName == y.Value.StudentName))
            return true;

        return false;
    }

    public int GetHashCode(KeyValuePair<int, Student> obj)
    {
        return obj.Key.GetHashCode();
    }
}

---------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		IDictionary<int, Student> studentDict = new Dictionary<int, Student>()
                    {
                        { 1, new Student(){ StudentID =1, StudentName = "Bill"}},
                        { 2, new Student(){ StudentID =2, StudentName = "Steve"}},
                        { 3, new Student(){ StudentID =3, StudentName = "Ram"}}
                    };
		
		var stud = studentDict[1];
		Console.WriteLine(stud.StudentID);
		Console.WriteLine(stud.StudentName);
	}
}

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
}