
C# - Partial Class
******************

	Each class in C# resides in a separate physical file with a .cs extension. 	
	C# provides the ability to have a single class implementation in multiple .cs files using the partial modifier keyword. 
	The partial modifier can be applied to a class, method, interface or structure.

	For example, the following MyPartialClass splits into two files, PartialClassFile1.cs and PartialClassFile2.cs:

	Example: PartialClassFile1.cs

	public partial class MyPartialClass
	{
		public MyPartialClass()
		{
		}

		public void Method1(int val)
		{
			Console.WriteLine(val);
		}
	}

	Example: PartialClassFile2.cs

	public partial class MyPartialClass
	{
		public void Method2(int val)
		{
			Console.WriteLine(val);
		}
	}


	MyPartialClass in PartialClassFile1.cs defines the constructor and one public method, Method1, 
	whereas PartialClassFile2 has only one public method, Method2. 
	
	The compiler combines these two partial classes into one class as below:

	
	Example: Partial class

	public class MyPartialClass
	{
		public MyPartialClass()
		{
		}
        
		public void Method1(int val)
		{
			Console.WriteLine(val);
		}

		public void Method2(int val)
		{
			Console.WriteLine(val);
		}
	}

	Partial Class Requirements:

	All the partial class definitions must be in the same assembly and namespace.
	
	All the parts must have the same accessibility like public or private, etc.
	
	If any part is declared abstract, sealed or base type then the whole class is declared of the same type.
	
	Different parts can have different base types and so the final class will inherit all the base types.
	
	The Partial modifier can only appear immediately before the keywords class, struct, or interface.
	
	Nested partial types are allowed.
	
	
	
	Advantages of Partial Class
	
	Multiple developers can work simultaneously with a single class in separate files.
	When working with automatically generated source, code can be added to the class without having to recreate the source file. 
	
	For example, Visual Studio separates HTML code for the UI and server side code into two separate files: .aspx and .cs files.

	
	Partial Methods
	
	A partial class or struct may contain partial methods. A partial method must be declared in one of the partial classes. 
	A partial method may or may not have an implementation. If the partial method doesn't have an implementation in any part then the compiler will not generate that method in the final class. 
	For example, consider the following partial method with a partial keyword:

	
	Example: PartialClassFile1.cs:
	
	public partial class MyPartialClass
	{
		partial void PartialMethod(int val);

		public MyPartialClass()
		{
            
		}

		public void Method2(int val)
		{
			Console.WriteLine(val);
		}
	}

	Example: PartialClassFile2.cs:

	public partial class MyPartialClass
	{
		public void Method1(int val)
		{
			Console.WriteLine(val);
		}

		partial void PartialMethod(int val)
		{
			Console.WriteLine(val);
		}
	}

	PartialClassFile1.cs contains the declaration of the partial method	and 
	PartialClassFile2.cs contains the implementation of the partial method.

	
	Requirements for Partial Method
	*******************************
	
	The partial method declaration must began with the partial modifier.

	The partial method can have a ref but not an out parameter.

	Partial methods are implicitly private methods.

	Partial methods can be static methods.
	
	Partial methods can be generic.

	
	The following image illustrates partial class and partial method:


	Partial Method

	The compiler combines the two partial classes into a single final class:


