	
	
	Extension Method 
	****************
	
	1. Extension methods are additional custom methods which were originally not included with the class.
	
	2. Extension methods can be added to custom, .NET Framework or third party classes, structs or interfaces.
	
	3. The first parameter of the extension method must be of the type for which the extension method is applicable, preceded by the this keyword.
	
	4. Extension methods can be used anywhere in the application by including the namespace of the extension method.
	
	
	Example : Code
	**************
	
	using System;
	namespace ExtensionMethods
	{
		public class IntExtension
		{
			public static bool IsGreaterThan(this int i,int value)
			{
				bool result = value > i;
					return result;
			}
		}
	}
		