using System;

public class Mobile
{
	public long Number;
	public float Cost;
	public string Color;
	public string Name;
	public string Model;
	
	public long MobileNum
	{
		get
		{
			return Number;
		}
		
		set
		{
			if(value<8000000000||value>1000000000)
				throw new Exception("Mobile Must Be +8000000000 to 9999999999");
			if(value<8000000000L||value>1000000000L)
				throw new Exception("Mobile Must Be +8000000000 to 9999999999");
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
			if(value<2500)
				throw new Exception("Mobile Cost Must Be Greater Than 2500");
			if(value>100000)
				throw new Exception("Mobile Cost Must Be Lesser Than 100000");
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
				throw new Exception("Mobile Color Must Not Be Null");
			if(value==string.Empty)
				throw new Exception("Mobile Color Must Not Be Empty");
		Color=value;
		}
	}
	
	public string MobileName
	{
		get
		{
			return Name;
		}
		
		set
		{
			if(value==null)
				throw new Exception("Mobile Name Must Not Be Null");
			if(value==string.Empty)
				throw new Exception("Mobile Name Must Not Be Empty");
			char[] data=value.ToUpper().ToCharArray();
			foreach(int d in data)
				if(d<65||d>90)
					throw new Exception("\n\t Must Be In Alphabet");
			
			Name=value;
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
				throw new Exception("\n\t Mobile Model Must Not Be Null");
			if(value==string.Empty)
				throw new Exception("\n\t Mobile Model Must Not Be Empty");
			
		Model=value;
		}
	}
	
	public void Calling(long CalledNo)
	{
		Console.WriteLine("\n\n\t Calling To : "+CalledNo);
	}
	
	public void Called(long CallingNo)
	{
		Console.WriteLine("\n\t Receive Call From : "+CallingNo);
	}
	
	public void SendMsg(string Msg,long CalledNo)
	{
		Console.WriteLine("\n\t "+Msg+" Sending The Msg To : "+CalledNo);
	}
	
	public void ReceiveMsg(string Msg,long CallingNo)
	{
		Console.WriteLine("\n\t "+Msg+" Receive Msg From : "+CallingNo);
	}
	
	public void Display()
	{
		Console.WriteLine("\n\t Mobile Number : "+Number);
		Console.WriteLine("\n\t Mobile Cost : "+Cost);
		Console.WriteLine("\n\t Mobile Color : "+Color);
		Console.WriteLine("\n\t Mobile Name : "+Name);
		Console.WriteLine("\n\t Mobile Model : "+Model);
	}
}

public class rsn
{
	public static void Main(string[] args)
	{
		Mobile m = new Mobile();
		m.Number=8943782869;
		m.MobileCost=25000;
		m.MobileColor="White";
		m.MobileName="Oppo";
		m.MobileModel="A57";
		m.Display();
		m.Calling(9677863344);
		m.Called(8476076029);
		m.SendMsg("Hello",9677863344);
		m.ReceiveMsg("Hi",8476076029);
	}
}