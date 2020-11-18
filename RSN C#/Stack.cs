
C# | Stack Class
****************

*	Stack represents a last-in, first out collection of object. It is used when you need a last-in, first-out access to items. 
	When you add an item in the list, it is called pushing the item and when you remove it, it is called popping the item. 
	This class comes under System.Collections namespace.

*	last-in, first out

using System;
using System.Collections;

namespace CollectionsApplication {
   
   public class Program {
      
     public static void Main(string[] args) {
         Stack st = new Stack();
         
         st.Push('A');
         st.Push('M');
         st.Push('G');
         st.Push('W');
         
         Console.WriteLine("Current stack: ");
         foreach (char c in st) {
            Console.Write(c + " ");
         }
         Console.WriteLine();
         
         st.Push('V');
         st.Push('H');
         Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
         Console.WriteLine("Current stack: ");
         foreach (char c in st) {
            Console.Write(c + " ");
         }
         
         Console.WriteLine();
         
         Console.WriteLine("Removing values ");
         st.Pop();
         st.Pop();
         st.Pop();
         
         Console.WriteLine("Current stack: ");
         foreach (char c in st) {
            Console.Write(c + " ");
         }
      }
   }
}