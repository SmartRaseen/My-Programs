//Param - variable length parameter

using System;

public class Program
    {
        public static void Main(string[] args)
        {
            TestM1();
            Console.ReadLine();
        }

        public static void ADDParameters(params int[] arguments)
        {
            int add = 0;
            Console.WriteLine("Param Length "+arguments.Length);
            foreach(int argu in arguments)
            {
                add += argu;
            }
            Console.WriteLine(add);
        }
		
        public static void TestAddParams()
        {
            ADDParameters(1);
            ADDParameters(1, 2, 3, 4, 5);
        }
	}