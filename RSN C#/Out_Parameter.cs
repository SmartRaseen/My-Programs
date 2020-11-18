// Out Parameter

using System;

public class Program
    {
        public static void Main(string[] args)
        {
            TestOutParameter();
            Console.ReadLine();
        }
		
        public static void M2(int v1,out int v2)
        {
            //Console.WriteLine("v1={0},v2={1}",v1,v2); out v2 is unassigned
            v1 = v1 + 100;
            //v2=v2*2000;
            v2 = v1 * 5; //v2 (y) is assigned
            Console.WriteLine("M2==> v1{0},v2={1}",v1,v2);
        }
        public static void TestOutParameter()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("x={0},y={1}",x,y);//5,10
            M2(x, out y);
            //M2(v2:out x,v1:y); //Using Named Arguments
            Console.WriteLine("After M2 x={0},y={1}",x,y);//5,525
        }