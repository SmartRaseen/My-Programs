using System;
					
public class Program
{
	public static void Main()
	{
		DateTime nominatedDate = new DateTime(2020, 05, 25);
		DateTime nextDate = new DateTime(2020, 07, 01);
		
		// Apr - Jun
        if (nominatedDate.Month >= 4 && nominatedDate.Month <= 6)
        {	
			DateTime updatedDate = new DateTime();
			if(nominatedDate.Month == 4) { updatedDate = nominatedDate.AddMonths(3); }
			if(nominatedDate.Month == 5) { updatedDate = nominatedDate.AddMonths(2); }
			if(nominatedDate.Month == 6) { updatedDate = nominatedDate.AddMonths(1); }
			
			long dateCount = Convert.ToInt64(updatedDate.ToString("dd"));
			dateCount = dateCount - 1;
			updatedDate = updatedDate.AddDays(- dateCount);
			
			if(nextDate >= updatedDate)
			{
				Console.WriteLine("\n return false : Nominated Date : "+nominatedDate.Date+ " But current date : "+nextDate);
			}
			else
			{
				Console.WriteLine("\n return true, You can't able to nominate this user for this month: "+nominatedDate);
			}	
		}
	}
}
