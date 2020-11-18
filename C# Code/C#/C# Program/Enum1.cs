using System;
	
public enum City {Chennai,Bangalore,Hyderabed}
public enum Designation {Manager,Admin,Developer}
public enum Color {Blue,White,Black,Red,Orange,Green}

public class Program
{
	public int eid;
	public string ename;
	public City ecity;
	public Designation design;
}	
public class rsn
{
	public static void Main()
	{
		Program p=new Program();
		p.eid=123;
		p.ename="Raseen";
		p.ecity=City.Chennai;
		p.design=Designation.Admin;
		Console.WriteLine("\n Employee Details Using Enum");
		Console.WriteLine(" ******** ******* ***** **** \n");
		Console.WriteLine("Employee ID : "+p.eid+"\n");
		Console.WriteLine("Employee Name : "+p.ename+"\n");
		Console.WriteLine("City Name : "+p.ecity+"\n");
		Console.WriteLine("Designation : "+p.design+"\n");
		Console.WriteLine("Color : "+Color.White+"\n");
	}
}

/*
using System;

public enum City { Nagore,TrPattinam,Nagai,Chennai,Trichy,Bangalore }
public enum Color { Red,White,Orange,Black,Blue,Green }
public enum Design { Admin,Developer }

public class Rsn
{
		public int id=123;
		public string name="Raseen";
}
public class mass
{
	public static void Main(string[] args)
	{
		Rsn r=new Rsn();
		Console.WriteLine("Raseen ID : "+r.id);
		Console.WriteLine("Raseen Name : "+r.name);
		Console.WriteLine("Raseen City : "+City.Nagore);
		Console.WriteLine("Raseen Color : "+Color.Red);
		Console.WriteLine("Raseen Design : "+Design.Developer);
	}
}
*/


using System;

public enum City { Nagore,TrPattinam,Nagai,Chennai,Trichy,Bangalore }
public enum Color { Red,White,Orange,Black,Blue,Green }
public enum Design { Admin,Developer }

public class Rsn
{
	public static void Main(string[] args)
	{
		int id=123;
		string name="Raseen";
		Console.WriteLine("Raseen ID : "+id);
		Console.WriteLine("Raseen Name : "+name);
		Console.WriteLine("Raseen City : "+City.Nagore);
		Console.WriteLine("Raseen Color : "+Color.Red);
		Console.WriteLine("Raseen Design : "+Design.Developer);
	}
}