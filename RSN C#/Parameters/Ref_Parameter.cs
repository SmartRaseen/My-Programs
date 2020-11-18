//Ref Parameter

using System;

public class Program
    {
        public static void Main(string[] args)
        {
            TestM1();
            Console.ReadLine();
        }

        // Ref Parameter

        public static void M1(int v1,ref int v2)
        {
            Console.WriteLine("\tM1==> v1={0},v2={1}",v1,v2); //5,10
            v1 = v1 + 100;  //105
            v2 = v2 * 2000;  //10 * 2000 //20000
            Console.WriteLine("\tM1==> v1={0},v2={1}",v1,v2); //105,20000
        }
        public static void TestM1()
        {
            int x = 5;																					// Difference Between Ref And Out Is 
            int y = 10;																				
            Console.WriteLine("x={0},y={1}",x,y); //5,10													Out is unassigned so we need to assign value using v2 = v1 + 10; 
            M1(x, ref y);
            Console.WriteLine("After M1 x={0},y={1}",x,y); //5,20000										But Ref Param we assign value like v2 = v2 + 10; No Problem 
        }
	}
