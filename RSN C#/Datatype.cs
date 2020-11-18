
        // To Get The Value Of Float				1.2f is a float (4 bytes).			
		  
	public class Program
		{
		public static void Main()
			{
				Console.WriteLine("Enter The Height : ");
				float height =float.Parse(Console.ReadLine());
				Console.WriteLine("\n Height Of The Student Is :"+height);
			}	
		}
			
		// To Get The Value Of String
		
		public static void Main()
			{
				Console.WriteLine("Enter The String : ");
				string values =Console.ReadLine();
				Console.WriteLine("\n The Values Is :"+values);
			}	
			
		// To Get The Value Of Int
		
		public static void Main()
			{
				Console.WriteLine("Enter The Data : ");
				int data =Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("\n The Data Is :"+data);
			}
			
		// To Get The Value Of Double							1.2 is a double (8 bytes).
		
		public static void Main()
			{		
				Console.WriteLine("Enter The Amount In Dollar : ");
				double dollar =Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("\n The Amount Of Dollar Is :"+dollar);
			}
			
		// To Get The Value Of Char
		
        public static void Main()
			{
				Console.WriteLine("Enter gender (M/m or F/f): ");
				char gender = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("\n The Gender is : "+gender);
			}