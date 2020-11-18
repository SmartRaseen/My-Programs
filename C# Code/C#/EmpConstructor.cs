using System;

namespace FirstConsoleApp.ClassesNProperties
{

	public class Employee
	{
	 //fields
	 
	 public readonly int id;
	 
	 private String name;
	 
	 private String city;
	 
	 private float salary;
	 //constructors
	 
	 public Emp()
	 
	 {
		 
		 Console.WriteLine("Emp Object Created"+GetHashCode());
		 
	 }
	 
	 //constructor overloading
	 public Emp(int id)
	 {
		  
		 Console.WriteLine("Emp Object Created"+GetHashCode());
		 this.id=id;
	 }
		public Emp(int id,String strName,String strcity,Float fsalary)
		{
			Console.WriteLine("Emp Object Created"+GetHashCode());
			this.id=id;
			name=strName;
			city=strcity;
			salary=fsalary;
		}
		
		
		//Getter and setters
		
		public string get name(){return name;}
		public string Get city(){return city;}
		public string Get salary(){return salary;}



		public void set Name(String s1)
		{
			//validate min len=3,max len=15,0nly alph
			
			if (s1==null)
				throw new Exception("Invalid Name!!!NAme must not be Null");
			if(s1==string.Empty)
				throw new Exception("Invalid Address!!! Address must not be Empty");
		    if(s1.Length<3)
				throw new Exception("Invalid Address!!! Address must be atleast 3 character");
			if(s1.Length>15)
				throw new Exception("Invalid Address!!! Address must be less than 16 character");
			char[] data=s1.ToUpper().ToCharArray();
			foreach(char c1 in data)
			{
				int x=(int)c1;
				if(x<65||x>90)
					throw new Exception("INVALID NAME!!! Name must have only Alphabets");
			}
			name=s1;
		}
		
		public void set Name(string s1)
		{
			//validate min len=3,max len=15,0nly alph
			
			if (s1==null)
				throw new Exception("Invalid Name!!!NAme must not be Null");
			if(s1==string.Empty)
				throw new Exception("Invalid Address!!! Address must not be Empty");
		    if(s1.Length<3)
				throw new Exception("Invalid Address!!! Address must be atleast 3 character");
			if(s1.Length>15)
				throw new Exception("Invalid Address!!! Address must be less than 16 character");
			char[] data=s1.ToUpper().ToCharArray();
			foreach(char c1 in data)
			{
				int x=(int)c1;
				if(x<65||x>90)
					throw new Exception("INVALID NAME!!! Name must have only Alphabets");
			}
			name=s1;
		}
	}
	public float salary
	{
		 get
		 {
			return salary;
		 }
		set
		{
			if(value<15000)
				throw new Exception("INVALID SALARY!!! must have morethan 15000");
			if(value>5000000)
				throw new Exception("INVALID SALARY!!! must have less than 5000000");
			salary=f1;
		}
	}
			//methods-non static
			
			public void startwork()
			{
				Console.WriteLine"Emp work started");
			}
			public void stopwork()
			{
				Console.WriteLine("Emp work stopped");
			}
			public void continuework()
			{
				Console.WriteLine("Emp work started again.....");
			}
			public void completework()
			{
				Console.WriteLine("Emp work completed");
			}
	        
			public void showDetails()
			{
					Console.WriteLine("Emp showDetails");
					//string details="ID"+id+"Name"+name+"City"+city+"Salary"+salary;
					stringBuilder sb=new StringBuilder(100);
					sb.Append("ID");
					sb.Append(id);
					sb.Append("Name");
					sb.Append(name);
					sb.Append("City");
					sb.Append(city);
					sb.Append("salar);
					Console.WriteLine(sb);
			}
}
   
					
					
			
			}
} 
   


			