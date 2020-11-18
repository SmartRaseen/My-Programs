using System;
using System.IO;

public class Solution
{
	public static void Main()
	{
		BinaryWriteFile();
		BinaryReadFile();
	}
	
	public static void BinaryWriteFile()
	{
		double data = 12.5;
		string result = "Data Written";
		bool condition = true;
	
		using(BinaryWriter writter = new BinaryWriter(File.Open(@"C:\Users\USER\Desktop\sample.txt",FileMode.Create)))
		{
			writter.Write(data);
			writter.Write(result);
			writter.Write(condition);
		}
		
		Console.WriteLine("\n Data Written Successfully...");
	}
	
	public static void BinaryReadFile()
	{
		using(BinaryReader reader = new BinaryReader(File.Open(@"C:\Users\USER\Desktop\sample.txt",FileMode.Open)))
		{
			Console.WriteLine("Read Double : "+reader.ReadDouble());
			Console.WriteLine("Read String : "+reader.ReadString());
			Console.WriteLine("Read Bool : "+reader.ReadBoolean());
		}
	}
}

