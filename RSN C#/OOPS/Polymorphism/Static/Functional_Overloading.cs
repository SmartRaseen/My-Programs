using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Overloading
{
    public class Program
    {
        void data (int i)
            {
                Console.WriteLine("\n Printing Integer : "+i);
            }
        void data (float f)
            {
                Console.WriteLine("\n Printing Float : "+f);
            }
        void data(double d)
        {
            Console.WriteLine("\n Printing Double : " + d);
        }
        void data (string s)
            {
                Console.WriteLine("\n Printing String : "+s);
            }
    public static void Main(string[] args)
        {
            Program p = new Program();
            p.data(5);
            p.data(25.5f);
            p.data(25.50);
            p.data("Raseen");
            Console.ReadLine();
        }
    }
}
