using System;
					
					
class Simple
{
	public void simple()
	{
	Console.WriteLine("Simple Class");							//Output
	}
}																Simple Class
class Derived : Simple											Derived Class	
{
	public void derived()
	{
	Console.WriteLine("Derived Class");
	}
}
public class Tester
{
	public static void Main()
	{
		Derived d=new Derived();
		d.simple();
		d.derived();
	}
}
					
					
					
public class simple
{																										//Output
	public void data()											
	{
		Console.WriteLine("Assalamu Alaikum Wa Rahumathulahi Wa Barakathahu \n");			Assalamu Alaikum Wa Rahumathulahi Wa Barakathahu	
	}
}
public class derived : simple 																Wa Alaikum Salam Wa Rahumathullahi Wa Barakathahu			
{
	public void info()
	{
		Console.WriteLine("Wa Alaikum Salam Wa Rahumathullahi Wa Barakathahu \n");			
	}
}
public class inheritance
{
	public static void Main()
	{
		derived d1=new derived();
		d1.data();
	    d1.info();
	}
}
