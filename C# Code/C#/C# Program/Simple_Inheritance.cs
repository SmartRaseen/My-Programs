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


//Another One Simple Inheritance

 class Tutorial
 {
  protected int TutorialID; 
  protected string TutorialName;
  
  public void SetTutorial(int pID,string pName) 
  {
   TutorialID=pID;
   TutorialName=pName;
  }
  
  public String GetTutorial()
  {
   return TutorialName;
  }
 }
  class Guru99Tutorial:Tutorial
  {
   		public void RenameTutorial(String pNewName)
   		{
    	TutorialName=pNewName;
   		}
  }
  
  public class Program 
  {
  		public static void Main(string[] args) 
  		{
   		Guru99Tutorial pTutor=new Guru99Tutorial();
			Console.WriteLine("\n\n");
   		Console.WriteLine("\n Simple Inheritance \n");
   		pTutor.RenameTutorial("\t .Net by Guru99");
    
   		Console.WriteLine(pTutor.GetTutorial()); 
  		}
  }