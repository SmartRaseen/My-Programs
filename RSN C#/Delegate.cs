
	A delegate is a reference type variable that holds the reference to a method. 
	The reference can be changed at runtime.
 
	Delegate declaration determines the methods that can be referenced by the delegate	
	
using System;

namespace Demo
{
	public delegate double MethodA(double x,double y);
	public delegate string MethodB();
	public delegate int MethodC();
	public delegate float MethodD();
	public delegate char MethodE();
	
	public class raseen
	{
		MethodA m1=null;
	}
}	



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Calculator
    {
        public double Add(double x, double y)
        {
            Console.WriteLine("Add Called");
            return x + y;
        }

        public double Divide(double x, double y)
        {
            Console.WriteLine("Divide Called");
            return x / y;
        }

        public double Subtract(double x, double y)
        {
            Console.WriteLine("Subtract Called");
            return x - y;
        }

        public double Product(double x, double y)
        {
            Console.WriteLine("Product Called");
            return x * y;
        }

        public string GetManufacture()
        {
            return "Casio";
        }

        public string GetModel()
        {
            return "2011";
        }

        public double GetCost()
        {
            return 1250.95;
        }
	}

    class Test
    { 
       
        public static void Main(string[] args)
        {
            
			Calculator c1 = new Calculator();
            double x = 0;
            MethodA m1 = c1.Add;
            x = m1(100, 50);
            Console.WriteLine("Result = " + x);
            Console.WriteLine("Method Name = " + m1.Method.Name);
            String mType = m1.Method.GetType().FullName;
            Console.WriteLine("Method Type = " + mType);
            String targetName = m1.Target.GetType().FullName;
            Console.WriteLine("Target Type = " + targetName);
            //#region A
            m1 = c1.Product;
            x = m1(100, 50);
            Console.WriteLine("Method Name = " + m1.Method.Name);
            Console.WriteLine("Result = " + x);
            m1 = c1.Divide;
            x = m1(100, 50);
            Console.WriteLine("Method Name = " + m1.Method.Name);
            Console.WriteLine("Result = " + x);
            Console.WriteLine("************************ MultiCast Demo *************************");
			m1 += c1.Add;
			m1 += c1.Divide;
            m1 += c1.Subtract;
            m1 += c1.Product;
            x = m1(100, 50);
            Console.WriteLine("Result = " + x);
            Console.WriteLine("************************ InvocationList Of Delegates *************************");

            Delegate[] methods = m1.GetInvocationList();
            foreach (MethodA mth in methods)
            {
                x = mth(100, 50);
                Console.Write("\t" + mth.Method.Name + ":");
                Console.WriteLine("Result " + x);
            }
		}
	}
}