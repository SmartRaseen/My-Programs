using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance
{
    class Person
    {
        public void data()
        {
            Console.WriteLine("\n This Is Person Class");
        }
    }
    class Bird : Person
    {
        public void info()
        {
            data();
            Console.WriteLine("\n This Is Bird Class");
        }
    }
    class Animal : Bird
    {
        public void file()
        {
            info();
            Console.WriteLine("\n This Is Animal Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.file();
            Console.ReadKey();
        }
    }
}

