
	Value Type and Reference Type
	*****************************

	We have learned about the data types in the previous section. 
	In C#, these data types are categorized based on how they store their value in the memory. 

	C# includes following categories of data types:

	*	Value type
	*	Reference type
	*	Pointer type

	Here, we will learn about value types and reference types.

	Value Type:
	***********
	
	A data type is a value type if it holds a data value within its own memory space. 
	It means variables of these data types directly contain their values.


	The following data types are all of value type:

		bool
		byte
		char
		decimal
		double
		enum
		float
		int
		long
		sbyte
		short
		struct
		uint
		ulong
		ushort
		
		
	Passing by Value:
	*****************
	
	When you pass a value type variable from one method to another method, the system creates a separate copy of a variable in another method, 
	so that if value got changed in the one method won't affect on the variable in another method.

	Example: Value Type

	static void ChangeValue(int x)
	{
		x =  200;

		Console.WriteLine(x);
	}

	static void Main(string[] args)
	{
		int i = 100;

		Console.WriteLine(i);
    
		ChangeValue(i);
    
		Console.WriteLine(i);
	}
		
	Output:
	100
	200
	100
	
	In the above example, variable i in Main() method remains unchanged even after we pass it to the ChangeValue() method and change it's value there.


	Reference Type
	**************
	
	Reference Type variable contains the address where the value is stored. 
	**********************************************************************
	
	Unlike value types, a reference type doesn't store its value directly. Instead, it stores the address where the value is being stored. 
	In other words, a reference type contains a pointer to another memory location that holds the data.


	The following data types are of reference type:

	*	String
	*	All arrays, even if their elements are value types
	*	Class
	*	Delegates
	
	
	Pass by Reference
	*****************
	
	When you pass a reference type variable from one method to another, 
	it doesn't create a new copy; instead, it passes the address of the variable. 
	If we now change the value of the variable in a method, it will also be reflected in the calling method.


	Example: Reference Type Variable

	static void ChangeReferenceType(Student std2)
	{
		std2.StudentName = "Steve";
	}

	static void Main(string[] args)
	{
		Student std1 = new Student();
		std1.StudentName = "Bill";
    
		ChangeReferenceType(std1);

		Console.WriteLine(std1.StudentName);
	}
	
	Output:
	Steve
	
	In the above example, since Student is an object, when we send the Student object std1 to the ChangeReferenceType() method,
	what is actually sent is the memory address of std1. Thus, when the ChangeReferenceType() method changes StudentName, 
	it is actually changing StudentName of std1, because std1 and std2 are both pointing to the same address in memory. Therefore, the output is Steve.
	

	Null
	****
	
	Reference types have null value by default, when they are not initialized. 
	For example, a string variable (or any other variable of reference type datatype) without a value assigned to it. 
	In this case, it has a null value, meaning it doesn't point to any other memory location, because it has no value yet.


	Null Reference type
	*******************

	A value type variable cannot be null because it holds a value not a memory address. 
	However, value type variables must be assigned some value before use. 
	The compiler will give an error if you try to use a local value type variable without assigning a value to it.

	Example: Compile Time Error

	void someFunction()
	{
		int i;

		Console.WriteLine(i);
	}