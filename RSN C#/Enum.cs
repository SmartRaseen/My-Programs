using System;

public enum City{Nagore,Bangalore,Chennai}
public enum Design{Manager,HR,Leader}

public class Enum
{
	public int eid;
	public string ename;
	public City ecity;
	public Design edesign;
}

public class program
{
	public static void Main(string[] args)
	{
		Enum e =new Enum();
		e.eid=123;
		e.ename="Raseen";
		e.ecity=City.Nagore;
		e.edesign=Design.HR;
		Console.WriteLine("Employye ID : "+e.eid);
		Console.WriteLine("Employee Name : "+e.ename);
		Console.WriteLine("Employee City : "+e.ecity);
		Console.WriteLine("Employee Design : "+e.edesign);
	}
} 