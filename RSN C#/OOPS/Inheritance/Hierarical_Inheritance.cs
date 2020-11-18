using System;

namespace Inheritance 
{
    class Father 
	{
        public void display() 
		{
         	Console.WriteLine("Display...");
       	}
    }

    class Son : Father 
	{
        public void displayOne() 
		{
           	Console.WriteLine("Display One");
        }
    }

      class Daughter : Father
	  {
         	public void displayTwo() 
		 {
            	   Console.WriteLine("Display Two");
         	 }
      	  }
	  
	class Mother : Father
	  {
         	public void displayThree() 
		 {
            	   Console.WriteLine("Display Three");
         	 }
          }
	   
	public class Test 
	{
      	public static void Main(string[] args) 
		{

         	Son s = new Son();
        	s.display();
         	s.displayOne();

         	Daughter d = new Daughter();
         	d.displayTwo();

			Mother m = new Mother();
         	m.displayThree();

      	}
   	}
}