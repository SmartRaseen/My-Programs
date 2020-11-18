using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIncDec
{
    class Program
    {
        static void m1()
        {
            int r = 35;
            int x = r-- + ++r;
            Console.WriteLine("\n Program - 1");
            Console.WriteLine(" ******* * *");
            Console.WriteLine(" x = " + x);  //  70
            Console.WriteLine(" r = " + r);  //  35
            Console.WriteLine("\n");
        }

        static void m2()
        {
            int r = 35;
            Console.WriteLine(" Program - 2");
            Console.WriteLine(" ******* * *");
            Console.WriteLine(" r= " + r);	//35
            Console.WriteLine(" r--= " + r--);	//35
            Console.WriteLine(" r= " + r);	//34
            Console.WriteLine(" ++r= " + ++r);	//35
            Console.WriteLine(" r= " + r);	//35
            Console.WriteLine("\n");
        }

        static void m3()
        {
            int k = 20;
            int j = --k + 2 * k;
            Console.WriteLine(" Program - 3");		
            Console.WriteLine(" ******* * *");
            Console.WriteLine(" j= " + j);		//57
            Console.WriteLine("\n");
        }

        static void m4()
        {
            int k = 20;
            int i = --k;
            int j = 2 * k;
            Console.WriteLine(" Program - 4");
            Console.WriteLine(" ******* * *");
            Console.WriteLine(" --k= " + i);	//19
            Console.WriteLine(" 2k= " + j);		//38
            int m = i + j;
            Console.WriteLine(" --k+2*k= " + m);	//57
            Console.WriteLine("\n");
        }

        static void m5()
        {
            int p = 3;
            int j = 22;
            int q = p * ++j;
            Console.WriteLine(" Program - 5");
            Console.WriteLine(" ******* * *");
            Console.WriteLine(" p * ++j= " + q);	//69
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            m1();
            m2();
            m3();
            m4();
            m5();
            Console.ReadLine();
        }
    }
}
