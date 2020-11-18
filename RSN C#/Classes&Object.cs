//Classes_Object

using System;

public class rsn
{
	public int id;
	public string name;
	public void Data(int ID,String Name)
	{
		this.id=ID;
		this.name=Name;
	}
	
	public void Display()
	{
		Console.WriteLine("Employee ID : "+this.id);
		Console.WriteLine("Employee Name : "+this.name);
	}
}

public class program
{
	public static void Main(string[] args)
	{
		rsn r= new rsn();
		r.Data(5,"Raseen");
		r.Display();
	}
}