//Reflection

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
									using System.Reflection;

				Reflection objects are used for obtaining type information at runtime. 
	Using System.Reflection namespace ,The classes that give access to the metadata of a running program.

	/*	Metadata is information stored in the assembly that describes the types and methods of the assembly 
		and provides other useful information about the assembly. 
		
		Assemblies are said to be self-describing because the metadata fully describes the contents of each module*/								
		
namespace Reflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String s1 = "Reflection.Program";
            QueryTypeMembersDemoA(s1);
            Console.ReadKey();
        }
            public static void QueryTypeMembersDemoA(String s1)
            {
                Type t = Type.GetType(s1);
                Console.WriteLine("Type..." + t.FullName);
                MethodInfo[] methods = t.GetMethods();
                foreach (MethodInfo m in methods)
                {
                    if (m != null)
                    {
                        Console.WriteLine("method..." + m.Name);
                        ParameterInfo[] pa = m.GetParameters();
                        foreach (ParameterInfo p in pa)
                        {
                            if (p != null)
                            {
                                Console.WriteLine("\t Param..." + p.Name);
                                Console.WriteLine("\t Type...." + p.ParameterType.FullName);
                            }
                        }
                    }
                }
            }
    }
}
