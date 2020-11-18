

// An interface in C# contains only the declaration of the methods, properties, and events, 
// but not the implementation

//Interface Detailed

using System;

interface Vehicle
{
	void ChangeGear(int a);
	void SpeedUp(int b);
	void ApplyBreak(int c);
}

public class Car : Vehicle
{
	int Speed;
	int Gear;
	
	public void ChangeGear(int gear)
	{
		Gear=gear;
	}
	
	public void SpeedUp(int increment)
	{
		Speed=Speed+increment;
	}
	
	public void ApplyBreak(int decrement)
	{
		Speed=Speed-decrement;
	}
	
	public void Status()
	{
		Console.WriteLine("\n\t Car Speed And Their Gear");
		Console.WriteLine("\t *** ***** *** ***** ****");
		Console.WriteLine("\n\t CarGear : "+Gear+" CarSpeed : "+Speed);
	}
}

public class Bike : Vehicle
{
	int Speed;
	int Gear;
	
	public void ChangeGear(int gear)
	{
		Gear=gear;
	}
	
	public void SpeedUp(int increment)
	{
		Speed=Speed+increment;
	}
	
	public void ApplyBreak(int decrement)
	{
		Speed=Speed-decrement;
	}
	
	public void Status()
	{
		Console.WriteLine("\n\n\t Bike Speed And Their Gear");
		Console.WriteLine("\t **** ***** *** ***** ****");
		Console.WriteLine("\n\t BikeGear : "+Gear+" BikeSpeed : "+Speed);
	}
}

public class program
{
	public static void Main(string[] args)
	{
	Car C = new Car();
	Bike BK = new Bike();
		C.ChangeGear(4);
		C.SpeedUp(85);
		C.ApplyBreak(20);
		C.Status();
		
		BK.ChangeGear(4);
		BK.SpeedUp(80);
		BK.ApplyBreak(20);
		BK.Status();
		
		display();
	}
	
	public static void display()
	{
		Console.WriteLine("Interface Name Is RSN");
	}
}