											  using System;
using System.Collections.Generic;
using System.Linq;
											using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s2 = string.Empty;

            for (int i = 0; i <= 4; i++)
                s2 += "data" + i;

            Console.WriteLine("\n The String Is : " + s2);
            Console.WriteLine("\n The String Is : " + s2.Length);
           
            Console.WriteLine("StringBuilder");
            StringBuilder s = new StringBuilder();

            Console.WriteLine("\n Length Of The StringBuilder Is :"+s.Length);
            Console.WriteLine("\n Capacity Of The StringBuilder Is :" + s.Capacity);

            s.Append("Good Morning Students");
            Console.WriteLine("\n String Append Is : "+s);
            Console.WriteLine("\n String Length Is : " + s.Length);
            Console.WriteLine("\n String Capacity Is : " + s.Capacity);
            
            s.Replace('o','i');
            Console.WriteLine("\n Replace 'o' To 'i' in String Append  ");
            Console.WriteLine("String Append Is : " + s);
            Console.WriteLine("String Length Is : " + s.Length);
            Console.WriteLine("String Capacity Is : " + s.Capacity);

            s.Remove(3,5);
            Console.WriteLine("\n Remove 3 To 5 in String Append  ");
            Console.WriteLine("String Append Is : " + s);
            Console.WriteLine("String Length Is : " + s.Length);
            Console.WriteLine("String Capacity Is : " + s.Capacity);

            Console.WriteLine("\n Insert 4 in String Append  ");
            s.Insert(4,"Raseen How Are You ");
            Console.WriteLine("String Append Is : " + s);
            Console.ReadKey();
        }
    }
}
