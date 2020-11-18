// Optional Parameter

using System;

public class Program
    {
        public static void Main(string[] args)
        {
            TestM1();
            Console.ReadLine();
        }

        public static void M3(int v1=123,int v2=456)
        {
            Console.WriteLine("\tM3==> v1={0},v2={1}",v1,v2);
            v1 = v1 + 100;
            v2 = v2 * 2000;
            Console.WriteLine("\tM3==> v1={0},v2={1}",v1,v2);
        }
        public static void TestOptionalParameter()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("x={0},y={1}",x,y);
            M3();
            //Console.WriteLine("After M3 x={0},y={1}",x,y);
            M3(x,y);
            M3(v2:x,v1:y);//Using Named Arguments
        }
	}