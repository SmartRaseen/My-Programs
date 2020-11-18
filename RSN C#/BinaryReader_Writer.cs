
	C# BinaryReader
	***************
	
	*	C# BinaryReader class is used to read binary information from stream. 
	*	It is found in System.IO namespace. It also supports reading string in specific encoding.
	
	
	C# BinaryWriter
	***************
	
	*	C# BinaryWriter class is used to write binary information into stream. 
	*	It is found in System.IO namespace. It also supports writing string in specific encoding.


using System;
using System.IO;

public class Employer
{	
	public static void Main()
	{
		BinaryWriteFile();
		BinaryReadFile();
	}
	
	public static void BinaryWriteFile()
	{
			try
			{
				string filePath = @"C:\Users\USER\Desktop\sample.txt";
				
				byte ID = 1;
				string Name = "Hameed Sulthan";
				double Salary = 50000;
				
				using(BinaryWriter writer = new BinaryWriter(File.Open(filePath,FileMode.Create)))
				{					
					writer.Write("\n Employee ID : "+ID);
					writer.Write("\n Employee Name : "+Name);
					writer.Write("\n Employee Salary : "+Salary);
					
					Console.WriteLine("\n Data Written Successfully...");
				}
			}
			
			catch(Exception ex)
			{
				Console.WriteLine("Error Message : {0}",ex.Message);
			}
	}
	
	public static void BinaryReadFile()
	{
		try
		{
			string filePath = @"C:\Users\USER\Desktop\sample.txt";
			
			using(BinaryReader reader = new BinaryReader(File.Open(filePath,FileMode.Open)))
			{
				Console.WriteLine("Read ID : "+reader.ReadByte());
				Console.WriteLine("Read Name : "+reader.ReadString());
				Console.WriteLine("Read Salary : "+reader.ReadDouble());
			}
		}
		
		catch(Exception ex)
		{
			Console.WriteLine("Error Message : {0}",ex.Message);
		}
	}
}