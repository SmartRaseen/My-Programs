// C# program to demonstrate the working  
// of Unary Arithmetic Operators 
using System; 
namespace Arithmetic { 
      
    class GFG { 
          
        // Main Function 
        static void Main(string[] args) 
        { 
              
            int a = 10, res; 
   
            // post-increment example: 
            // res is assigned 10 only,  
            // a is not updated yet 
            res = a++; 
              
             //a becomes 11 now 
            Console.WriteLine("a is {0} and res is {1}", a, res); // a=11  res=10 
           
           
            // post-decrement example: 
            // res is assigned 11 only, a is not updated yet 
            res = a--; 
              
            //a becomes 10 now 
            Console.WriteLine("a is {0} and res is {1}", a, res);   //a=10  res=11
           
           
            // pre-increment example: 
            // res is assigned 11 now since a 
            // is updated here itself 
            res = ++a; 
              
            // a and res have same values = 11 
            Console.WriteLine("a is {0} and res is {1}", a, res); //a=11 res=11
           
           
            // pre-decrement example: 
            // res is assigned 10 only since 
            // a is updated here itself 
            res = --a; 
              
            // a and res have same values = 10 
            Console.WriteLine("a is {0} and res is {1}",a, res);  //a=10 res=10
           
             
        } 
    } 
} 
Output :

a is 11 and res is 10
a is 10 and res is 11
a is 11 and res is 11
a is 10 and res is 10
