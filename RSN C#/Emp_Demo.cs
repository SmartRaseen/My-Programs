using System;

public class Emp
{
	public string Name;
	public string Gender;
	public int Age;
	public string Address;
	public string Email;
	
	public string GetName()
		{
			return Name;
		}
	
	public string GetGender()
		{
			return Gender;
		}
	
	public int GetAge()
		{
			return Age;
		}
	
	public string GetAddress()
		{
			return Address;
		}
	
	public string GetEmail()
		{
			return Email;
		}
	
	public void SetName(string s1)
		{
			if(s1==null)
				throw new Exception("Name Must Not Be Null");
			if(s1==string.Empty)
				throw new Exception("Name Must Not Be Empty");
			if(s1.Length<3)
				throw new Exception("Name Must Not Be Lesser Than 3 Characters");
			if(s1.Length>30)
				throw new Exception("Name Must Not Be Greater Than 30 Characters");
			char[] data=s1.ToUpper().ToLower().ToCharArray();
			
			foreach(char c1 in data)
			{
				int x=(int)c1;
				
				if((x<65||x>90)&&(x<97||x>122))
					throw new Exception("\n\t Value Must Be On Alphabet");
			}
			Name=s1;
		}
		
		public void SetGender(string s1)
			{
				if(s1==null)
					throw new Exception("Gender Must Not Be Null");
				if(s1==string.Empty)
					throw new Exception("Gender Must Not Be Empty");
			
				char[] data=s1.ToUpper().ToLower().ToCharArray();
			
				foreach(char c1 in data)
					{	
						int x=(int)c1;
				
						if((x<65||x>90)&&(x<97||x>122))
						throw new Exception("\n\t Gender Must Be On Alphabet");
					}
			
				switch(s1)
				{
					case "Male":
					case "male":
						s1="Male";
						break;
					case "Female":
						s1="Female";
						break;
					default:
						s1="Unspecified";
						break;
				}
					Gender=s1;
			}
	
		
		public void SetAge(int a1)
			{
				if(a1==0)
					throw new Exception("Age Must Not Be Zero");
				Age=a1;
			}
	
	public void SetAddress(string s1)
		{
			if(s1==null)
				throw new Exception("Address Must Not Be Null");
			if(s1==string.Empty)
				throw new Exception("Address Must Not Be Empty");
			if(s1.Length<10)
				throw new Exception("Address Must Not Be Lesser Than 10 Characters");
			if(s1.Length>40)
				throw new Exception("Address Must Not Be Greater Than 40 Characters");

			Address=s1;
		}
	
		public void SetEmail(string s1)
		{
			if(s1==null)
				throw new Exception("Email Must Not Be Null");
			if(s1==string.Empty)
				throw new Exception("Email Must Not Be Empty");
			if(s1.Length<10)
				throw new Exception("Email Must Not Be Lesser Than 10 Characters");
			if(s1.Length>40)
				throw new Exception("Email Must Not Be Greater Than 40 Characters");
			if(!(s1.Contains("@")))
				throw new Exception("Email Must Contains @ Symbol");
			Email=s1;
		}
	
		public void SendRequest(string Request)
		{
			Console.WriteLine("\n\t Send Request From : " +Request);
		}
	
		public void RequestAccept(string Accept)
		{
			Console.WriteLine("\n\t Request Accepted By : " +Accept);
		}
	
		public void SendMsg(string Msg,string Request)
		{
			Console.WriteLine("\n\t "+Msg+" (Msg From) : " +Request);
		}
	
		public void Reply(string Msg,string Accept)
		{
			Console.WriteLine("\n\t "+Msg+" (Msg From) : " +Accept);
		}
	
	public void Display()
	{
		Console.WriteLine("\n\t Employee Name : "+Name);
		Console.WriteLine("\n\t Employee Gender : "+Gender);
		Console.WriteLine("\n\t Employee Age : "+Age);
		Console.WriteLine("\n\t Employee Address : "+Address);
		Console.WriteLine("\n\t Employee Email : "+Email);
	}
}

public class rsn
{
	public static void Main(string[] args)
	{
		Emp e = new Emp();
		e.SetName("Raseen");
		e.SetGender("Male");
		e.SetAge(21);
		e.SetAddress("12,Syed Palli Tank Street,Nagore");
		e.SetEmail("smartraseen05@gamil.com");
		e.Display();
		Console.WriteLine("\n\n\t\tJust To Try FaceBook Process");
		Console.WriteLine("\t\t****************************");
		
		e.SendRequest("Ayisha");
		e.RequestAccept("RSN");
		e.SendMsg("Assalamu Alaikum Wa Rahumathullahi Wa Barakathahu","Ayisha");
		e.Reply("Wa Alaikum Salam Wa Rahuathullahi Wa Barakathahu","RSN");
	}
}