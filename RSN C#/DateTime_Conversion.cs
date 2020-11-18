using System;
using System.Linq;

/*ToSTring("") :
if you use "hh" ->> The hour, using a 12-hour clock from 01 to 12.
if you use "HH" ->> The hour, using a 24-hour clock from 00 to 23.
if you add "tt" ->> The Am/Pm designator.*/

/*string iString = "2005-05-05 22:12 PM";
DateTime oDate = DateTime.ParseExact(iString, "yyyy-MM-dd HH:mm tt",null);*/

public class Program
{
	public static void Main()
	{
		string s="07:45AM";
		DateTime time = DateTime.MinValue;
		
         if(s.Contains("PM") || s.Contains("pm"))
            time = Convert.ToDateTime(s);	
		 
		else if(s.Contains("AM") || s.Contains("am"))
			time = Convert.ToDateTime(s);	
		
		Console.WriteLine(time.ToString("HH:mm"));
		
	/*	DateTime timeValue = Convert.ToDateTime("07:45 PM");
    	Console.WriteLine(timeValue.ToString("HH:mm")); */
	}
}

