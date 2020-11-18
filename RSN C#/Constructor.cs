C# Constructor


In C#, constructor is a special method which is invoked automatically at the time of object creation. 
It is used to initialize the data members of new object generally. The constructor in C# has the same name as class or struct.

Types of constructors in C#.
*********************************************

*	Default constructor
*	Parameterized constructor
*	Constructor Overloading
*	Constructor Chaining

C# Default Constructor
**********************

A constructor which has no argument is known as default constructor. 
It is invoked at the time of creating object.


C# Default Constructor Example: Having Main() within class


using System;  
   public class Employee  
    {  
        public Employee()  
        {  
            Console.WriteLine("Default Constructor Invoked");  
        }  
        public static void Main(string[] args)  
        {  
            Employee e1 = new Employee();  
            Employee e2 = new Employee();  
        }  
    } 
	
Output:

Default Constructor Invoked 
Default Constructor Invoked

	
C# Default Constructor Example: Having Main() in another class


Let's see another example of default constructor where we are having Main() method in another class.

using System;  
   public class Employee  
    {  
        public Employee()  
        {  
            Console.WriteLine("Default Constructor Invoked");  
        }  
    }  
   class TestEmployee{  
       public static void Main(string[] args)  
        {  
            Employee e1 = new Employee();  
            Employee e2 = new Employee();  
        }  
    }  
Output:

Default Constructor Invoked 
Default Constructor Invoked	

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

C# Parameterized Constructor
A constructor which has parameters is called parameterized constructor. It is used to provide different values to distinct objects.

using System;  
   public class Employee  
    {  
        public int id;   
        public String name;  
        public float salary;  
        public Employee(int i, String n,float s)  
        {  
            id = i;  
            name = n;  
            salary = s;  
        }  
        public void display()  
        {  
            Console.WriteLine(id + " " + name+" "+salary);  
        }  
   }  
   class TestEmployee{  
       public static void Main(string[] args)  
        {  
            Employee e1 = new Employee(101, "Sonoo", 890000f);  
            Employee e2 = new Employee(102, "Mahesh", 490000f);  
            e1.display();  
            e2.display();  
  
        }  
    }  
Output:

101 Sonoo 890000
102 Mahesh 490000

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

C# Constructor Overloading
In c#, we can overload the constructor by creating another constructor with same method name but with different parameters.

using System;

public class Employee
{
	public int EmpID;
	public string Name;
	
	public Employee()
	{
		EmpID = 26;
		Name = "Raseen";
	}
	public Employee(int i, string n)
	{
		EmpID = i;
		Name = n;
	}
}

public class Test
{
	public static void Main(string[] args)
	{
		Employee e = new Employee();  // Default Constructor
		Employee e1 = new Employee(22,"Geetha"); // Parameterized Constructor
		
		Console.WriteLine("EmpID : "+e.EmpID+"\n Name : "+e.Name);
		Console.WriteLine("EmpID : "+e1.EmpID+"\n Name : "+e1.Name);
	}
}

Output
******

EmpID : 26
 Name : Raseen
EmpID : 22
 Name : Geetha
 
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 
 C# Constructor Chaining
In c#, Constructor Chaining is an approach to invoke one constructor from another constructor. 
To achieve constructor chaining we need to use this keyword after our constructor definition.

using System;
namespace Tutlane
{
    class User
    {
        public User()
        {
            Console.Write("Hi, ");
        }

        public User(string a): this()
        {
            Console.Write(a);
        }

        public User(string a, string b): this("welcome")
        {
            Console.Write(a + " " + b);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            User user1 = new User(" to", "tutlane");
            Console.WriteLine();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}

Output
******
							
Hi, welcome to tutlane

Press Enter Key to Exit..

