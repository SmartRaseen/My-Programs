using System;
					
public class Enum
{
	public static void Main()
	{
		Console.WriteLine(WeekDays.Friday);
		Console.WriteLine((int)WeekDays.Friday);
	}
}

enum WeekDays
{
    Monday = 0,
    Tuesday =1,
    Wednesday = 2,
    Thursday = 3,
    Friday = 4,
    Saturday =5,
    Sunday = 6
}


//output

// Friday
// 4