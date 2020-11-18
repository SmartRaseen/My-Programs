using System;

public class Mobile
{
	private long Number;
	private float Cost;
	private string Color=string.Empty;
	private string Model=string.Empty;
	
	public long MobileNum
	{
		get
		{
			return Number;
		}
		set
		{
			if(value<8000000000||value>10000000000)
			{
				throw new Exception("Value Must Be Greater Than 8000000000 && Lesser Than 10000000000");
			}
			if(value<8000000000L||value>10000000000L)
			{
				throw new Exception("Value Must Be Greater Than 80000000L && Lesser Than 10000000000L");
			}
			Number=value;
		}
	}
	
	public float MobileCost
	{
		get
		{
			return Cost;
		}
		set
		{
			if(value<0)
			{
				Console.WriteLine("Value Must Be Greater Than Zero");
			}
			if(value%50!=0)
			{
				throw new Exception("Value Must Be Multiplies Of 50");
			}
			if(value>100000)
			{
				throw new Exception("Value Must Not Be Greater Than 1 Lakh");
			}
			Cost=value;
		}
	}
	
	public string MobileColor
	{
		get
		{
			return Color;
		}
		set
		{
			if(value==null)
				throw new Exception("Color Must Not Be Null");
			if(value==string.Emptyt)
				throw new Exception("Color Must Not Be Empty");
			if(value.Length<3)
				throw new Exception("Color Must Not Be Lesser Than 3");
			if(value.Length>20)
				throw new Exception("Color Must Not Be Greater Than 20");
		    Color=value;
		}
	}
	
	public string MobileModel
	{
		get
		{
			return Model;
		}
		set
		{
			if(value==null)
				Console.WriteLine("Values Must Not Be Null");
			if(value==String.Empty)
				Console.WriteLine("Values Must Not Be Empty");
			if(value.Length>20)
				Console.WriteLine("Values Must Not Be Greater Than 20");
			if(value.Length<3)
				Console.WriteLine("Values Must Not Be Lesser Than 3");
			/*char[] data=value.ToUpper().ToCharArray();
			foreach(char c1 in data)
			{
				int x = (int) c1;
			if(x<65||x>90)
				Console.WriteLine("Values Must Be On Alphabets Only");
			}*/
			Model=value;
		}
	}
	
	public void MakeaCall(long CalledNo)
	{
		Console.WriteLine();
		Console.WriteLine("\n Calling To ..."+CalledNo);
	}
	
	public void ReceivedCall(long CallingNo)
	{
		Console.WriteLine();
		Console.WriteLine("\n Received Call From ..."+CallingNo);
	}
	
	public void SendMsg(string Msg,long CalledNo)
	{
		Console.WriteLine();
		Console.WriteLine(Msg+" Sending Msg To ..."+CalledNo);
	}
	
	public void ReceiveMsg(string Msg,long CallingNo)
	{
		Console.WriteLine();
		Console.WriteLine(Msg+" Receive Msg From ..."+CallingNo);
	}
	
	public void ShowDetails()
	{
		Console.WriteLine("\n");
		Console.WriteLine("\n Details Of Mobile Phone");
		Console.WriteLine("  ******* ** ****** *****\n");
		
		Console.WriteLine("\n Mobile Number : "+Number);
		Console.WriteLine("\n Mobile Cost : "+Cost);
		Console.WriteLine("\n Mobile Color : "+Color);
		Console.WriteLine("\n Mobile Model : "+Model);
	}
}

public class Test
{
	public static void Main(string[] args)
	{
		Mobile m = new Mobile();
		
		m.MobileNum=8608821831;
		Console.WriteLine("\n Mobile Number 1 = "+m.MobileNum);
		m.MobileNum=9488253162;
		Console.WriteLine("\n Mobile Number 2 = "+m.MobileNum);
		
		m.MobileCost= 12500;
		
		m.MobileColor="White";
		
		m.MobileModel="Oppo A57";
		
		m.MakeaCall(9488253162);
		m.ReceivedCall(8608821831);
		m.SendMsg("\n Hello, How Are You ?",8608821831);
		m.ReceiveMsg("\n Hii, Im Fine",9488253162);
		m.ShowDetails();
	}
}